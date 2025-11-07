# Lab 4.1 - Adding RAG to your application with a single prompt

In this lab you will learn how to build a simple Retrieval-Augmented Generation (RAG) system using a single prompt. By injecting knowledge into your promopt, you can already fine-tune your model. The knowledge is not part of the trained model, so you inject this to the prompt. The LLM does the res. It combines the knowledge from your domain with the rich language features to give structured and human-like answers. This is perfect in scenarios like customer support, where you want to provide accurate and context-aware responses based on specific policies or information.

>The code snippets and instructions in this lab are designed to be integrated into the existing console application you created in the previous labs. You can also choose to fully focus on this part of the workshop. For this a starter solution has been created for you in the `exercises/module4/start/. The code snippets below will build on this starter solution so that we will not overcomplicate samples. Be aware that file paths and namespaces might differ from your previous projects.

## Building RAG with a single prompt

### Steps

#### 1. Open the solution 
In the solution explorer in your codespace by right-clickin the solution file and choose `Open Solution`

#### 2. Create ChatWithRag file 
In your project, create a new file named `ChatWithRag.cs`. Leave the constructor empty for now.

#### 3. Add a new function called RAG_with_single_prompt 
Use the following code

```csharp
        public async Task RAG_with_single_prompt(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {
        }
```

#### 4. Update Program.cs 
Call this function from the main `Program.cs`

```csharp
    await new ChatWithRag().RAG_with_single_prompt(model, endpoint, token, config);
```

#### 5. Add the KernelBuilder
Now we will add the KernelBuild configuration to the method. We receive the deploymentName, endpoint and apiKey from the method parameters. We will use the OpenAI Chat Completion service. ChatCompletion is used to genereate conversational responses. In this case this the Chat Completion service will be used to process prompts that combine your domain knowledge (the "retrieval" part) with the model's language capabilities to generate informed, context-aware responses.

Add the following code to add the KernelBuilder and OpenAI Chat Completion service

```csharp
    IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
    var client = new OpenAIClient(new ApiKeyCredential(apiKey), new OpenAIClientOptions { Endpoint = new Uri(endpoint) });
    kernelBuilder.AddOpenAIChatCompletion(deploymentName, client);
    Kernel kernel = kernelBuilder.Build();
```

#### 6. Create a simple sample question 
Now think of a question that can be asked to a model but will return nonsensical answers without context. For example, questions about venue policies. In the `exercises/datasets/venue-policies` folder you will find many sample venue policies from concert venues all over the world. Read through a number of them and see what kind of of information can be found within these polcies.

Pick one of these venues and create a question that requires knowledge about the venue policies.

An typical question that a concert visitor could ask is:

```text
I booked tickets for a concert tonight in venue AFAS Live!.
I have this small black backpack, not big like for school, more like the mini
festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
Is this allowed? 
```

Imagine asking this question to a model without any context about the venue policies. The model could give all kinds of answers, but they will not be based on the actual venue policies. So we need to make sure that the model has the right context to answer this question correctly.

### 7. Add the question in the application
Now we will add the question to the application. Normally we would do this by getting thi question from user input or a chat, but for now we will just code this directly in the method. Add this on top of the method.

```csharp
var question =
    """
    I booked tickets for a concert tonight in venue AFAS Live!.
    I have this small black backpack, not big like for school, more like the mini
    festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
    Is this allowed? 
    """;
```

#### 8. Getting a response
Now we need to add a method to generate a good response based on the question and the venue policy. For that we will pick a venue policy. In our example we ask something for AFAS Live in Amsterdam. So we will use the venue policy from the `exercises/datasets/venue-policies/AFAS_Live.md`

We will add the following code
```csharp
private async Task<string> GetResponseOnQuestion(Kernel kernel, string question)
{
    var policyContext = File.ReadAllText("/workspaces/HOLSemanticKernel/exercises/module4/datasets/venue-policies/AFAS_Live.md");

    ChatHistory chatHistory = new();
    chatHistory.AddSystemMessage("You are a helpful assistant that answers questions from people that go to a concert and have questions about the venue.");
    chatHistory.AddSystemMessage("Always use the policy information provided in the prompt");
    chatHistory.AddSystemMessage($"### Venue Policy\n {policyContext}");

    chatHistory.AddUserMessage(question);

    var executionSettings = new OpenAIPromptExecutionSettings
    {
        ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
    };
    
    var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
    var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
    return result.Content;
}
```

This are the step we do here:
- Load policy file - Reads venue policy from disk
- Create chat history - Initialize conversation container
- Add system messages - Define AI role, rules, and inject policy data
- Add user question - Include customer's question
- Configure settings - Enable automatic function calling
- Get AI service - Retrieve chat completion service from kernel
- Send & receive - Process conversation and return AI response

Make sure you use the right path to the venue policy file on your system. In this case we just inject the policy as context to the prompt.

#### 9. Use an LLM to understand the question
We inject the venue poliy as context to the prompt. But we have more venues, more policies and questions can be about all of them. The code we made is not flexible enough. We should make it smarter. We could use an LLM to pick the right venue policy based on the question. For that we will forst create a method that tries to determine the venue based on the question. Add this method to the `ChatWithRag` class. We want to use structured output for this. So we will create a class called `SelectedVenue` in a new file `SelectedVenue.cs`

```csharp
public class SelectedVenue
{
    public string venueName { get; set; }
}
```

```csharp 
private async Task<string> GetVenueFromQuestion(Kernel kernel, string question)
{
    ChatHistory chatHistory = new();

    chatHistory.AddSystemMessage("You are a helpful asistant that finds the name of a venue from a question.");
    chatHistory.AddSystemMessage("Always get the information from the question. Never search the web or use internal knowledge!");
    chatHistory.AddUserMessage(question);
    var executionSettings = new OpenAIPromptExecutionSettings
    {
        ResponseFormat = typeof(SelectedVenue)
    };
    var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
    var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
    var selectedVenue = JsonSerializer.Deserialize<SelectedVenue>(result.ToString());
    return selectedVenue.venueName;
}
```
#### 10. Get the right policy based on the venue name
Now we know the venue name we can use this to load the right venue policy file. For that we can also use an LLM.To make things a bit more string typed we will create a new class called `SelectedFile` in a new file `SelectedFile.cs`

```csharp
public class SelectedFile
{
    public string file { get; set; }
}
```
Then we can create the method that will get the right file based on the venue name. Becuase the files are not always named exactly like the venue name we will use an LLM to pick the right file. Add the following code to the `ChatWithRag` class.

```csharp
private async Task<string> GetFileContentsFromRepo(Kernel kernel, string venueName)
{
    //Get a list of files from the venue policy repository
    var directory = "/workspaces/HOLSemanticKernel/exercises/module4/datasets/venue-policies";
    var fileList = string.Join("\n", System.IO.Directory.GetFiles(directory, "*.md").Select(f => System.IO.Path.GetFileName(f)));
    
    var systemprompt = "You are an expert at finding the correct file based on a user question.";
    var fileListPrompt = $"The following is a list of files available:\n{fileList}";
    var fileQuestion = $"Which file contains the venue policy for the venue named '{venueName}'?";
    
    var chatHistory = new ChatHistory();
    chatHistory.AddSystemMessage(systemprompt);
    chatHistory.AddUserMessage(fileListPrompt);
    chatHistory.AddUserMessage(fileQuestion);

    var executionSettings = new OpenAIPromptExecutionSettings
    {
        ResponseFormat = typeof(SelectedFile)
    };

    var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
    var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
    
    var fileResult = JsonSerializer.Deserialize<SelectedFile>(result.ToString());
    var fullfilename = Path.Combine(directory, fileResult.file);

    if (System.IO.File.Exists(fullfilename))
    {
        using (var file = File.OpenText(fullfilename))
        {
            return file.ReadToEnd();
        }
    }
    
    return "No Policy information found";

}
```

#### 11. Update GetResponseOnQuestion method
Now we need to update the `GetResponseOnQuestion` method to use the new methods to get the right venue policy based on the question. Update the method as follows:

```csharp
var venue = await GetVenueFromQuestion(kernel, question);
var policyContext = await GetFileContentsFromRepo(kernel, venue);
var response = await GetResponseOnQuestion(kernel, question, policyContext);
```

Notice here that we added policyContext as a parameter to the `GetResponseOnQuestion` method. Make sure to update the method signature as well. Also make sure that the implementation uses the passed policyContext instead of reading the file from disk.

#### 12. Run the application
Now you are ready to run the application. Run the console application and see the response from the model. You should see that the model is able to answer the question based on the venue policy.

Try also with other questions and other venue policies. See how the model is able to answer questions based on the injected knowledge.


## The End 
This concludes lab 4.1. You have learned how to build a simple RAG system using a single prompt and how to use an LLM to pick the right knowledge based on the user question.