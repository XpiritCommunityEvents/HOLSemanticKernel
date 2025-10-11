# Lab 2.1

In this lab, we will introduce the Agent Framework into your application to make communication with your LLMs more flexible and powerful.

## Add Agent Framework to your application

**Goal:** Add the necessary dependencies and initialization code for using Agent Framework to your application.

> 👉🏻 We assume that you continue to work in the application in `main/src/HolAgentFramework`.

### Steps

1. Add the necessary Nuget packages to your application. In your Terminal window, type:

    ```pwsh
    dotnet add package Microsoft.Agents.AI --prerelease

    dotnet add package Microsoft.Agents.AI.OpenAI --prerelease
    ```

    This adds the base package for using Agent Framework plus a separate extension package for connecting with OpenAI Inference models. `Microsoft.Agents.AI` has a transitive dependency on `Microsoft.Extensions.AI`, which brings integration with LLM models to the .NET framework.

2. Leave the code for reading the API token from user secrets in your code, but remove the rest of the code added in the previous lab that works with the `ChatCompletionsClient`. You can also remove the nuget packages `Azure.AI.Inference` and `Azure.Identity` from your program as we're going to make more generic and pluggable code with Agent Framework.  

3. Replace the removed code with:

    ```csharp
    var chatClient = new ChatClient(model, new ApiKeyCredential(token), new OpenAIClientOptions()
    {
        Endpoint = new Uri(endpoint)
    });

    var agent = chatClient.CreateAIAgent(name: "GloboTicket Assistant");
    ```

    We now have an instance of a `ChatClient` from the `Microsoft.Extensions.AI` framework and used the `CreateAIAgent` extension method from the `Microsoft.Agents.AI` package to wrap it in a `ChatClientAgent` instance. We will interact with this agent from now on.

## Build a simple chat client

**Goal:** build a simple chat client loop that lets the user have a conversation with the LLM.

1. Add the following loop to your application:

    ```csharp
    Console.OutputEncoding = Encoding.UTF8; // the LLM may respond with emojis, so we need UTF8 support
    Console.WriteLine("Hi! I am your AI assistant. Talk to me:");

    while (true)
    {
        Console.WriteLine();

        var prompt = Console.ReadLine();

        // synchronous call
        var response = await agent.RunAsync(prompt!);
        Console.WriteLine(response.Text);
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

## Add history using a Thread

**Goal:** include the chat history in your interaction with the LLM.

Your chat app is not very useful yet. As you have noticed, the LLM does not remember anything of what you previously said. We need to add the chat history as context every time we call the LLM to generate content. In Agent Framework, this is called a Thread.

### Steps

1. Obtain an `AgentThread` object just before the `while` loop, and after creating the agent. It will hold the conversation history between the user and the LLM.

    ```csharp
    var agent = chatClient.CreateAIAgent(name: "GloboTicket Assistant");
    var thread = agent.GetNewThread(); // <-- add this

    while (true)
    ```

2. Now, add the `thread` variable to the `agent.RunAsync` method's parameter list.  

    ```csharp
    var response = await agent.RunAsync(prompt!, thread);
    
    Console.WriteLine(response.Text);
    ```

    Inspect the code. The agent will use the `AgentThread` to keep track of the conversation, so it knows what you said before. Agent Framework will also add every response from the LLM to this `thread` as an _assistant message_. This way you can build a full conversation history where you can see who said what.

3. Run the application and retry a conversation with the LLM where you refer to something you said earlier. Does this feel more like a real conversation?

## Give the LLM a system prompt

**Goal:** insert a system prompt just like we did in module 1.

### Steps

1. Just before initializing the `agent` object, create a `string` which holds the system instructions and pass it to the `CreateAIAgent` method:

    ```csharp
    var instructions = 
        "You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point.";

    var agent = chatClient.CreateAIAgent(instructions, name: "GloboTicket Assistant");
    ```

2. Run the application again. Can you notice a difference in how it responds?

3. Try asking when your favorite artist is in town. How does it respond? Chances are that it will make up something on the spot. This is not something we want.

4. Improve the system prompt:

    ```csharp
    var instructions = 
        "You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point.  Do not make things up when you don't know the answer. Just tell the user that you don't know the answer based on your knowledge.";
    ```

5. Run the application again and try asking the same question. How does it respond now?

We will give the LLM "knowledge" about artists and tickets in later labs.

## Set prompt execution settings

**Goal:** passing prompt execution settings like Temperature and Top-P to the LLM to control output.

### Steps

1. Create an instance of `ChatClientAgentRunOptions` and set the parameters:

    ```csharp
    var options = new ChatClientAgentRunOptions
    {
        ChatOptions = new()
        {
            MaxOutputTokens = 500,
            Temperature = 0.5f,
            TopP = 1.0f,
            FrequencyPenalty = 0.0f,
            PresencePenalty = 0.0f
        }
    };
    ```

2. Add the `options` to the parameter list of `agent.RunAsync`

    ```csharp
    // ...
    
    var response = await agent.RunAsync(prompt!, thread, options);

    //...
    ```

3. Run the application and confirm that it still works. Play around with the values of these parameters to see if there are any differences in how the LLM responds.

## Use streaming responses

**Goal:** switch to streaming responses to make your LLM application feel faster and more responsive.

### Steps

1. Replace the call to `RunAsync()` with `RunStreamingAsync()` and process the results in a streaming fashion:

    ```csharp
    // streaming call
    var responseStream = agent.RunStreamingAsync(prompt!, thread, options);
    await foreach (var chunk in responseStream)
    {
        Console.Write(chunk.Text);
    }
    ```

This concludes lab 2.1.
