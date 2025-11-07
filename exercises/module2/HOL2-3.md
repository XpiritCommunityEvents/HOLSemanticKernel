# Lab 2.3 - Model Context Protocol integration

Model Context Protocol (MCP) servers can easily be integrated into Semantic Kernel so that they can also become an available tool for your LLM. This lab focuses on integrating an the GitHub MCP server with Semantic Kernel.

## Install ModelContextProtocol package

### Steps

- Install the `ModelContextProtocol` nuget package into your application:

  ```pwsh
  dotnet add package ModelContextProtocol --prerelease
  ```

We will integrate the GitHub MCP server, which requires your authentication token. We will add this to the user secrets.

- Open a Terminal and sign in to GitHub with the GitHub CLI:

  ```pwsh
  gh auth login
  ```

  Go through the sign in process, using the `Login with a web browser` flow.

- After authenticating, you can fetch the token using `gh auth token`:

  ```pwsh
  gh auth token
  ```

- Copy the output, which is a string that looks something like `gho_.......`

- Next, add this token to your .NET User Secrets:

  ```pwsh
  dotnet user-secrets set "GitHubToken" "<token>" -p .\HolSemanticKernel.csproj
  ```

## Setup Authentication

- Configure GitHub authentication using the GitHub CLI or environment variables:

  ```pwsh
  # Option 1: Use GitHub CLI (recommended)
  gh auth login
  
  # Option 2: Set environment variable with personal access token
  $env:GITHUB_TOKEN = "your_github_token_here"
  ```

- Get the current repository context:

  ```pwsh
  # Get current repository information
  git remote get-url origin
  ```

## Integrate MCP Server with Semantic Kernel

- Add the MCP server to your Semantic Kernel configuration:

  ```csharp
  using Microsoft.SemanticKernel;
  using ModelContextProtocol;
  using System.Diagnostics;
  
  var builder = Kernel.CreateBuilder();
  
  // Add your AI service (Azure OpenAI, OpenAI, etc.)
  builder.AddAzureOpenAIChatCompletion(/* your config */);
  
  // Get GitHub token from environment or GitHub CLI
  var githubToken = Environment.GetEnvironmentVariable("GITHUB_TOKEN") 
                   ?? await GetGitHubTokenFromCLI();
  
  // Get current repository context
  var repoInfo = await GetCurrentRepositoryInfo();
  
  // Load MCP configuration with authentication
  var mcpConfig = await File.ReadAllTextAsync("mcp-config.json");
  mcpConfig = mcpConfig.Replace("${GITHUB_TOKEN}", githubToken);
  
  builder.Services.AddMcp(mcpConfig);
  
  var kernel = builder.Build();
  
  // Set repository context for MCP server
  await kernel.InvokePromptAsync($"Set the current repository context to {repoInfo.Owner}/{repoInfo.Name}");
  ```

- Helper methods for authentication and repository context:

  ```csharp
  private static async Task<string> GetGitHubTokenFromCLI()
  {
      try
      {
          var process = new Process
          {
              StartInfo = new ProcessStartInfo
              {
                  FileName = "gh",
                  Arguments = "auth token",
                  RedirectStandardOutput = true,
                  UseShellExecute = false,
                  CreateNoWindow = true
              }
          };
          
          process.Start();
          var token = await process.StandardOutput.ReadToEndAsync();
          await process.WaitForExitAsync();
          
          return token.Trim();
      }
      catch
      {
          throw new InvalidOperationException("GitHub CLI not found or not authenticated. Run 'gh auth login' first.");
      }
  }
  
  private static async Task<(string Owner, string Name)> GetCurrentRepositoryInfo()
  {
      try
      {
          var process = new Process
          {
              StartInfo = new ProcessStartInfo
              {
                  FileName = "git",
                  Arguments = "remote get-url origin",
                  RedirectStandardOutput = true,
                  UseShellExecute = false,
                  CreateNoWindow = true
              }
          };
          
          process.Start();
          var remoteUrl = await process.StandardOutput.ReadToEndAsync();
          await process.WaitForExitAsync();
          
          // Parse GitHub URL to extract owner/repo
          var url = remoteUrl.Trim();
          var match = System.Text.RegularExpressions.Regex.Match(url, @"github\.com[:/]([^/]+)/([^/.]+)");
          
          if (match.Success)
          {
              return (match.Groups[1].Value, match.Groups[2].Value);
          }
          
          throw new InvalidOperationException("Could not parse GitHub repository information from remote URL");
      }
      catch
      {
          throw new InvalidOperationException("Not in a Git repository or no GitHub remote found");
      }
  }
  ```

- Use the MCP tools with current repository context:

  ```csharp
  // The GitHub MCP server tools will be automatically available with current repo context
  var response = await kernel.InvokePromptAsync("List the recent issues in this repository");
  Console.WriteLine(response);
  
  // Work with current repository files
  var fileResponse = await kernel.InvokePromptAsync("Show me the contents of the README.md file");
  Console.WriteLine(fileResponse);
  
  // Get repository statistics
  var statsResponse = await kernel.InvokePromptAsync("What are the top contributors to this repository?");
  Console.WriteLine(statsResponse);
  ```

## Authentication Methods

The GitHub MCP server supports multiple authentication methods:

1. **GitHub CLI (Recommended)**: Use `gh auth login` to authenticate and the MCP server will use the CLI's stored credentials
2. **Personal Access Token**: Set the `GITHUB_TOKEN` environment variable with a personal access token
3. **OAuth App**: Configure OAuth authentication for your application

## Repository Context

The MCP server automatically detects the current repository context when properly authenticated, allowing you to:
- Query repository information
- Access files and directories
- Manage issues and pull requests
- View repository statistics and contributors
- Search repository content