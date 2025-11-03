# Lab 2.1 - Turning Prompts into Conversations

In this lab, we will introduce Semantic Kernel into your application to make communication with your LLMs more flexible and powerful.

## Add Semantic Kernel to your application

**Goal:** Add the necessary dependencies and initialization code for using Semantic Kernel to your application.

> 👉🏻 We assume that you continue to work in the application in `main/src/HolSemanticKernel`.

### Steps

1. Add the necessary Nuget packages to your application. In your Terminal window, type:

    ```pwsh
    dotnet add package Microsoft.SemanticKernel

    dotnet add package Microsoft.SemanticKernel.Connectors.AzureAIInference --prerelease
    ```

    This adds the base package for using Semantic Kernel plus a separate extension package for connecting with Azure AI Inference models.

2. Leave the code for reading the API token from user secrets in your code, but remove the rest of the code added in the previous lab that works with the `ChatCompletionsClient`.
3. Replace the removed code with:

    ```csharp
    var kernelBuilder = Kernel
        .CreateBuilder()
        .AddAzureAIInferenceChatCompletion(model, token, new Uri(endpoint));

    var kernel = kernelBuilder.Build();
    ```

    We now have an instance of the Semantic Kernel to interact with. The `AddAzureAIInferenceChatCompletion` comes from the `Microsoft.SemanticKernel.Connectors.AzureAIInference`. Semantic Kernel is pluggable, so by adding connector packages for other AI vendors, you can mix and match them using the kernel instance.

## Build a simple chat client

**Goal:** build a simple chat client loop that lets the user have a conversation with the LLM.

1. Add the following loop to your application:

    ```csharp

    Console.WriteLine("Hi! I am your AI assistant. Talk to me:");

    while (true)
    {
        Console.WriteLine();

        var prompt = Console.ReadLine();

        var response = await kernel.InvokePromptAsync(prompt);
    
        Console.WriteLine(response.GetValue<string>());
    }
    ```

2. Start the application and test if you can interact with the LLM. Now try the following prompt sequence:

    ```txt
    My name is <your name>
    ```

    The LLM will respond by greeting you.

    ```txt
    Tell me my name
    ```

    How does the LLM repond?

## Add chat history

**Goal:** include the chat history in your interaction with the LLM.

Your chat app is not very useful yet. As you have noticed, the LLM does not remember anything of what you previously said. We need to add the chat history as context every time we call the LLM to generate content.

### Steps

1. Instantiate a `ChatHistory` object just before the `while` loop. It will hold the conversation history between the user and the LLM.

    ```csharp
    var history = new ChatHistory();
    ```

2. Now instead of interacting with the `kernel` instance directly, ask it for an instance of `IChatCompletionService`:

    ```csharp
    var chatCompletionService = kernel.Services.GetService<IChatCompletionService>();
    ```

    We're using the kernel's dependency injection container to obtain a reference to a service that implements the `IChatCompletionService`.

3. Inside the `while` loop, replace the call to `kernel.InvokePromptAsync()` with:

    ```csharp
    chatHistory.AddUserMessage(prompt!);
    
    var response = await chatCompletionService!.GetChatMessageContentsAsync(chatHistory);
    
    Console.WriteLine(response.Last().Content);
    ```

    Inspect the code. We are using the `chatHistory` object here to keep track of the conversation. Every prompt is added as a _user message_ to the list and we're supplying this history to the `GetChatMessageContentsAsync` method.

    Semantic Kernel will also add every response from the LLM to this `chatHistory` object as an _assistant message_. This way you can build a full conversation history where you can see who said what.

4. Run the application and retry a conversation with the LLM where you refer to something you said earlier. Does this feel more like a real conversation?

## Give the LLM a system prompt

**Goal:** insert a system prompt just like we did in module 1.

### Steps

1. Just after initializing the `chatHistory` object, add the following statement:

    ```csharp
    var chatHistory = new ChatHistory();
    chatHistory.AddSystemMessage("You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point.");
    ```

2. Run the application again. Can you notice a difference in how it responds?

3. Try asking when your favorite artist is in town. How does it respond? Chances are that it will make up something on the spot. This is not something we want.

4. Improve the system prompt:

    ```csharp
    var chatHistory = new ChatHistory();
    chatHistory.AddSystemMessage("You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point.  Do not make things up when you don't know the answer. Just tell the user that you don't know the answer based on your knowledge.");
    ```

5. Run the application again and try asking the same question. How does it respond now?

We will give the LLM "knowledge" about artists and tickets later.

## Set prompt execution settings

**Goal:** passing prompt execution settings like Temperature and Top-P to the LLM to control output.

### Steps

1. Create an instance of `AzureOpenAIPromptExecutionSettings` and set the parameters:

    ```csharp
    var executionSettings = new AzureOpenAIPromptExecutionSettings
    {
        MaxTokens = 500,
        Temperature = 0.5,
        TopP = 1.0,
        FrequencyPenalty = 0.0,
        PresencePenalty = 0.0
    };
    ```

2. Add the `executionSettings` and `kernel` to the parameter list of

    ```csharp
    // ...
    
    var response = await chatCompletionService!.GetChatMessageContentsAsync(chatHistory, executionSettings, kernel);

    //...
    ```

3. Run the application and confirm that it still works. Play around with the values of these parameters to see if there are any differences.

## Use streaming responses

**Goal:** switch to streaming responses to make your LLM application feel faster and more responsive.

### Steps

1. Replace the call to `GetChatMessageContentsAsync()` with `GetStreamingChatMessageContentsAsync()` and process the results in a streaming fashion:

    ```csharp
    // streaming call
    var responseStream = chatCompletionService!.GetStreamingChatMessageContentsAsync(chatHistory, executionSettings, kernel);
    await foreach (var response in responseStream)
    {
        Console.Write(response.Content);
    }
    ```

This concludes lab 2.1.