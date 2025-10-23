# Lab 1.2

## 7. Get Credentials for API Access

**Goal:** Connect C# apps to GitHub Models (for Semantic Kernel, etc).

### Steps

1. On the [GitHub Models Marketplace](https://github.com/marketplace?type=models), click **GPT 5 Mini**  
[Direct link](https://github.com/marketplace/models/azure-openai/gpt-4o)
2. Click **Use this model**.
3. Under **Configure Authentication**, click **Create Personal Access Token**.
4. On the next screen, select **Public Repositories**.
5. Ensure **Models: Read Only** is checked.
6. Generate your token.  
**Copy and store it securely.**
7. Also record:

    - Token
    - Endpoint: `https://models.github.ai/inference`
    - Model: `openai/gpt-4o`

```csharp
// For C# SDK
var token = "<your stored token>";
var endpoint = "https://models.github.ai/inference";
var model = "openai/gpt-4o";
````

# Step 2

- Start your VS Code space
- in your codespace go to your files
- open the `src` folder
- in the Terminal window, go to the folder `main/src/HolSemanticKernel`
- type `dotnet run`

# Step 3

Goal: It is important to keep the API token to your model safe. Otherwise people can use your LLM at your cost. Therefore we will move the API key to .NET user secrets. Never commit a secret key to your version control system!

- In the terminal window type

```pwsh
dotnet user-secrets set "ApiKey" "<key>" -p .\HolSemanticKernel.csproj
```

In order to read the secret value, we need a Nuget package:

```pwsh
dotnet add package Microsoft.Extensions.Configuration.UserSecrets
```

Then, at the top of your `Program.cs`, read the token from your configuration using `ConfigurationBuilder`:

```csharp
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .Build();

var token = config["ApiKey"];
```

# Step 4 Use your Model

Now that you have added the api token, it is time to fire your first LLM query

- First add the neccessary packages to your program

```pwsh
dotnet add package Azure.AI.Inference --prerelease  
dotnet add package Azure.Identity --prerelease  
```

```csharp
var client = new ChatCompletionsClient(new Uri(endpoint), new AzureKeyCredential(token), new AzureAIInferenceClientOptions());
var requestOptions = new ChatCompletionsOptions()
{
    Model = model,
    Messages = [
        new ChatRequestUserMessage("Tell me a joke about computers")
    ]
};
var resp = await client.CompleteAsync(requestOptions);

Console.WriteLine(resp.Value.Content);
```

Run the application and see what joke the LLM came up with.
