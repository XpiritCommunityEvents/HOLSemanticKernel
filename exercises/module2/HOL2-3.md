# Lab 2.3 - Model Context Protocol integration

Model Context Protocol (MCP) servers can easily be integrated into Semantic Kernel so that they can also become an available tool for your LLM. This lab focuses on integrating an the GitHub MCP server with Semantic Kernel.

## Setup authentication

### Steps

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

## Integrate the `ModelContextProtocol` package

The [`ModelContextProtocol` package](https://www.nuget.org/packages/ModelContextProtocol) is a library for developing and integrating MCP Servers in .NET applications. We will use it to integrate the GitHub MCP server with Semantic Kernel.

- Install the `ModelContextProtocol` nuget package into your application:

  ```pwsh
  dotnet add package ModelContextProtocol --prerelease -p .\HolSemanticKernel.csproj
  ```

- Bring in the necessary `using` statement in the top of your `Program.cs`:

  ```csharp
  using ModelContextProtocol.Client;
  ```

- From the `ModelContextProtocol` library, we can use an `McpClient` which we can add as a tool in the kernel. Add the following to your `Program.cs` _before_ the call to `kernelBuilder.Build();`:

   ```csharp
   var mcpClient = await McpClient.CreateAsync(new HttpClientTransport(
    new HttpClientTransportOptions
    {
        Name = "GitHub",
        Endpoint = new Uri("https://api.githubcopilot.com/mcp/"),
        AdditionalHeaders = new Dictionary<string, string>
        {
            ["Authorization"] = $"Bearer {config["GitHubToken"]}"
        }
    }));
  ```

  We now have an instance of `McpClient` which can call services using the MCP protocol. The sample uses the public GitHub MCP endpoint, and leverages the `GitHubToken` variable you added to the .NET User Secrets in the previous steps.

  In order to make the `McpClient` usable in Semantic Kernel, we have to transform it into a plugin. Every tool that the MCP Server exposes can be made available as callable functions with the following code:

  ```csharp
  var tools = await mcpClient.ListToolsAsync();

  kernelBuilder.Plugins.AddFromFunctions(
    pluginName: "GitHub",
    functions: tools.Select(x => x.AsKernelFunction()));
   ```

  The LLM is now aware of the GitHub MCP server and can invoke it to solve a user question.

  - Start your application and ask the LLM to list the issues in the `XpiritCommunityEvents/HOLSemanticKernel` repo. It should list the issues from GitHub.
  - Ask it to create a new issue in the `XpiritCommunityEvents/HOLSemanticKernel` repo, give it a title and a description and tell it to add no labels and no assignees. It should respond with the URL to the newly created issue.

This shows how easy it is to integrate any MCP with LLMs. As long as you have your authentication set up, and the MCP Server is reachable from where your application runs, the LLM can issue a `tool_call` response, which it routed to the MCP through Semantic Kernel.

This concludes lab 2.3.