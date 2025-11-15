# Lab 1.2 - Connect to an LLM 

In this lab, you will connect your C# application to an LLM through the Azure AI Inference API. You will generate and securely store an API key, configure your application, and run your first query against a model.

---

## Get Credentials for API Access

**Goal:** Obtain API credentials and configuration details to connect your application to GitHub Models.

### Steps

1. Go to the [GitHub Models Marketplace](https://github.com/marketplace?type=models).
2. Locate and click **GPT 4o**.
   [Direct link to model](https://github.com/marketplace/models/azure-openai/gpt-4o)
3. Click **Use this model**.
4. Under **Configure Authentication**, select **Create Personal Access Token**.
5. Make sure that the **Resource owner** is set to **XpiritCommunityEvents**
6. On the next screen, select **Public Repositories**.
7. Ensure that **Models: Read Only** is checked.
8. Generate your token and copy it securely.
9. Record the following information for later use:

   * Token
   * Endpoint: `https://models.github.ai/orgs/XpiritCommunityEvents/inference`
   * Model: `openai/gpt-4o`

   This is already configured in the appsettings.json file

   ```json
   {
      "OpenAI": {
         "Model": "openai/gpt-4o",
         "EndPoint": "https://models.github.ai/orgs/XpiritCommunityEvents/inference",
         "ApiKey": "<set this in your user secrets>"
      }
   }
   ```

---

## Configure and Run the Application

**Goal:** Start the application and prepare the environment for connecting to the model.

### Steps

1. Open your VS Code Codespace.
2. Navigate to your project files.
3. Open the `src\HolSemanticKernel` folder.
4. Right Click the `HolSemanticKernel.sln` file and select **Open Solution**. The C# Dev Kit will now load the solution, which gives you Intellisense.
5. Run the application from the terminal, or by right clicking the project file and starting a debug session:

   ```pwsh
   dotnet run
   ```

---

## Secure Your API Key with .NET User Secrets

**Goal:** Protect your API key using .NET’s User Secrets feature to prevent accidental exposure in source control.

### Steps

1. In the terminal, run the following command to store your API key securely:

   ```pwsh
   dotnet user-secrets set "OpenAI:ApiKey" "<key>" -p ./HolSemanticKernel.csproj
   ```

2. Install the required NuGet package:

   ```pwsh
   dotnet add package Microsoft.Extensions.Configuration.UserSecrets
   ```

3. In your `Program.cs`, load the secret value using the `ConfigurationBuilder`:

   ```csharp
   using Microsoft.Extensions.Configuration;

   var config = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
       .AddUserSecrets<Program>()
       .Build();

   var model = config["OpenAI:Model"];
   var endpoint = config["OpenAI:EndPoint"];
   var token = config["OpenAI:ApiKey"];

   Console.WriteLine($"Model: {model}");
   Console.WriteLine($"Endpoint: {endpoint}");
   ```

4. Confirm that the application retrieves and displays the model and endpoint correctly when you run it:

   ```pwsh
   dotnet run
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
2. Add the following usings to your program

   ```csharp
   using Azure;
   using Azure.AI.Inference.Chat;
   ```

3. Add the following code in your main program with the following example to send a prompt to the model:

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

4. Run the application:

   ```pwsh
   dotnet run
   ```

4. Verify that the model responds with a joke.

---

This concludes Lab 1.2.
