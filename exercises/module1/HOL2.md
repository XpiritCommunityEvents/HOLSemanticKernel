## 7.Get Credentials for API Access

**Goal:** Connect C# apps to GitHub Models (for Semantic Kernel, etc).

### Steps
1. On the [GitHub Models Marketplace](https://github.com/marketplace?type=models), click **GPT 5 Mini**  
[Direct link](https://github.com/marketplace/models/azure-openai/gpt-5-mini)
2. Click **Use this model**.
3. Under **Configure Authentication**, click **Create Personal Access Token**.
4. On the next screen, select **Public Repositories**.
5. Ensure **Models: Read Only** is checked.
6. Generate your token.  
**Copy and store it securely.**
7. Also record:
- Token
- Endpoint: `https://models.github.ai/inference`
- Model: `openai/gpt-5-mini`

```csharp
// For C# SDK
var token = "<your stored token>";
var endpoint = "https://models.github.ai/inference";
var model = "openai/gpt-5-mini";
````

# Step 2
- Start your VS Code space
- in your codespace got to your files
- open the src folder
- in the terminal window go to the folder mainsrc/HOlSemanticKernel
- type `dotnet run`

# Step 3
Goal: The API token to your model is important. Otherwise people can use your LLM at your cost. Therefore we will store  the API key in the user secrets

- In the terminal window type 

```
dotnet user-secrets set "ApiKey" "<key>" -p .\HolSemanticKernel.csproj
```

# Step 4 Use your Model
Now that you have added the api key, it is time to fire your first LLM query

- First add the neccessary packages to your program

```
dotnet add package Azure.AI.Inference --prerelease  
dotnet add package Azure.Identity --prerelease  
```


```
 var client = new ChatCompletionsClient(new Uri(endpoint), new AzureKeyCredential(key), new AzureAIInferenceClientOptions());
var requestOptions = new ChatCompletionsOptions()
{
    Model = model,
    Messages = [
        new ChatRequestUserMessage("Tell me a joke about computers")
    ]
};
var resp = await client.CompleteAsync(requestOptions); 
```