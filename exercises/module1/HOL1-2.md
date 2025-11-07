# Lab 1.2 - Connect Semantic Kernel to GitHub Models

In this lab, you will connect your C# application to GitHub Models through the Azure AI Inference API. You will generate and securely store an API key, configure your application, and run your first query against a model.

---

## Get Credentials for API Access

**Goal:** Obtain API credentials and configuration details to connect your application to GitHub Models.

### Steps

1. Go to the [GitHub Models Marketplace](https://github.com/marketplace?type=models).
2. Locate and click **GPT 5 Mini**.
   [Direct link to model](https://github.com/marketplace/models/azure-openai/gpt-4o)
3. Click **Use this model**.
4. Under **Configure Authentication**, select **Create Personal Access Token**.
5. On the next screen, select **Public Repositories**.
6. Ensure that **Models: Read Only** is checked.
7. Generate your token and copy it securely.
8. Record the following information for later use:

   * Token
   * Endpoint: `https://models.github.ai/inference`
   * Model: `openai/gpt-4o`

   This is already configured in the appsettings.json file

   ```csharp
   // For C# SDK
   var token = "<your stored token>";
   var endpoint = "https://models.github.ai/inference";
   var model = "openai/gpt-4o";
   ```

---

## Configure and Run the Application

**Goal:** Start the application and prepare the environment for connecting to the model.

### Steps

1. Open your VS Code Codespace.
2. Navigate to your project files.
3. Open the `src` folder.
4. In the terminal, go to `main/src/HolSemanticKernel`.
5. Run the application:

   ```pwsh
   dotnet run
   ```

---

## Secure Your API Key with .NET User Secrets

**Goal:** Protect your API key using .NET’s User Secrets feature to prevent accidental exposure in source control.

### Steps

1. In the terminal, run the following command to store your API key securely:

   ```pwsh
   dotnet user-secrets set "OpenAI:ApiKey" "<key>" -p .\HolSemanticKernel.csproj
   ```

2. Install the required NuGet package:

   ```pwsh
   dotnet add package Microsoft.Extensions.Configuration.UserSecrets
   ```

3. In your `Program.cs`, load the secret value using the `ConfigurationBuilder`:

   ```csharp
   var config = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
       .AddUserSecrets<Program>()
       .Build();

   var model = config["OpenAI:Model"];
   var endpoint = config["OpenAI:EndPoint"];
   var token = config["OpenAI:ApiKey"];
   ```

> Note: Never commit your API key to version control. Treat it as confidential information to prevent unauthorized usage.

---

## Use Your Model

**Goal:** Run your first query against the GitHub Model API.

### Steps

1. Add the required NuGet packages to your project:

   ```pwsh
   dotnet add package Azure.AI.Inference --prerelease
   dotnet add package Azure.Identity --prerelease
   ```

2. Replace the code in your main program with the following example to send a prompt to the model:

   ```csharp
   var client = new ChatCompletionsClient(
       new Uri(endpoint),
       new AzureKeyCredential(token),
       new AzureAIInferenceClientOptions());

   var requestOptions = new ChatCompletionsOptions()
   {
       Model = model,
       Messages =
       [
           new ChatRequestUserMessage("Tell me a joke about computers")
       ]
   };

   var resp = await client.CompleteAsync(requestOptions);
   Console.WriteLine(resp.Value.Content);
   ```

3. Run the application:

   ```pwsh
   dotnet run
   ```

4. Verify that the model responds with a joke.

---

This concludes Lab 1.2.
