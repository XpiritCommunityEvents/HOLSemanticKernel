# Lab 5.1 - Integrating Semantic Kernel into an existing application

In this lab, we will integrate Semantic Kernel into a less-than-trivial application: GloboTicket. This is to give you a better sense of how everything comes together in real life scenario.

For these exercises, we assume that you went through the exercises in modules 1 through 4, where you implemented individual building blocks like setting up Semantic Kernel, adding tools and plugins, implementing RAG and building agents. We are going to reuse that knowledge in this lab.

## Prerequisites

We have a fully functioning GloboTicket application in this repository for you to work with. The solution is located in the [starter](./starter) folder. You can open the solution with the Soluction Explorer in VSCode. It contains of 3 projects:

- `frontend` - An ASP.NET MVC application containing the UI
- `catalog` - An ASP.NET WebApi application that serves the available shows, et cetera
- `ordering` - An ASP.NET WebApi application that handles ticket orders and (fake) payments

A short description and sequence diagram of the application can be found in [GloboTicket DataFlow Diagram](./starter/GloboTicket-DataFlow-Diagram.md).

The GloboTicket app accesses a SQL Server database via Entity Framework Core. If you are working with this repository from a Dev Container or on GitHub Codespaces, it will automaticall start a SQL Server Docker container with an empty GloboTicket database. You can also start it yourself by running:

```pwsh
docker run -d -p 1433:1433 marcelv/globoticket-default-db
```

Upon startup of the `catalog` service, the database will be populated with sample data automatically.

We will use Semantic Kernel from the `frontend` app so that we can have a chat interface with the user. For your convenience, so you can focus on Semantic Kernel integration, we have some building blocks available for you:

- [ChatHub](./starter/frontend/Services/AI/ChatHub.cs): a `SignalR` hub used for implementing bi-directional chat between the UI and the LLM
- [chat.js](./starter/frontend/wwwroot/js/chat.js): client side JavaScript client for the `ChatHub` SignalR hub
- [Chat view](./starter/frontend/Views/Chat/Index.cshtml): UI for the Chat Assistant
- [ChatHistoryRepository](./starter/frontend/Services/AI/ChatHistoryRepository.cs): this static class stores `ChatHistory` objects in a simple `Dictionary`. It allows you to keep track of `ChatHistory` for multiple users. The `Dictionary` is indexed by a `sessionId`. We recommend using the SignalR connection ID for the key to store and retrieve a user's `ChatHistory`
- Configuration: the [`frontend/appsettings.json`](./starter/frontend/appsettings.json) has an `OpenAI` section that already has the `Endpoint` and `Model` pre-filled. You will need to add the `OpenAI:ApiKey` setting as a .NET User Secret to this project yourself.

  > ⚠️ Make sure not to commit any secrets to your Git repo!

Also, the necessary Nuget packages are already added to the `frontend.csproj` file:

- `Microsoft.SemanticKernel`
- `Microsoft.SemanticKernel.Connectors.AzureAIInference`

Now it's up to you to bring all the pieces together, so in the remainder of this lab, we'll be less specific about the code snippets you have to add.

## Implement an LLM chat loop in the `frontend` app

### Steps

#### Add the Kernel as a DI service

- Open the [`globoticket.sln`](./starter/globoticket.sln) solution in the [`starter`](./starter/) folder.
- First, make the `Kernel` object available for use in the `frontend` app by adding it to the ASP.NET dependency injection container. You can add the kernel with a `Scoped` lifecycle, which creates a new `Kernel` instance for every user request. The `Kernel` is a lightweight resource, so `Scoped` is a well suited lifetime, ensuring user isolation.

  💡 Hint: use this overload to add the `Kernel`:

  ```csharp
  builder.Services.AddScoped(serviceProvider => {
    // initialize your Kernel here using the KernelBuilder, use builder.Configuration to read the `OpenAI` settings
  });
  ```

#### Build a simple `ChatAssistant`

- Implement a new class called `ChatAssistant`, give it a `Handle` method with the following signature `Task Handle(string sessionId, string prompt)`.
- Make sure that the `ChatAssistant` class gets a `Kernel` object and a `IHubContext<ChatHub>` injected as dependencies. You will need them in the `Handle` method.
- Implement the `Handle` method to do the following:
  - Fetch the `ChatHistory` for the current session by using the `ChatHistoryRepository.GetOrCreateHistory()` method - use the `sessionId` parameter as the dictionary key.
  - Add the user's prompt to the `ChatHistory`.
  - Resolve an `IChatCompletionService` from the `kernel.Services`.
  - Invoke the `GetStreamingChatMessageContentsAsync` method on the chat completion service and process the response in a streaming manner.

    💡 Refer to [`module2`](../module2/HOL2-1.md) how to implement a streaming chat

  - On every response (part) received, pass it on to the SignalR hub using:

    ```csharp
    await hubContext.Clients
        .Client(sessionId.ToString())
        .SendAsync("ReceiveMessagePart", response.Content);
    ```

- Add the `ChatAssistant` class to the DI container as  a `Scoped` dependency in the `Program.cs`.

#### Wire up the `ChatAssistant` in the `ChatHub`

- Open the `ChatHub` and add the `ChatAssistant` class as an injected dependency.
- Inspect the `SendMessage` method. It already sends 2 messages to the client: `NewResponse` and `ResponseDone`, to mark the start and end of a new LLM response. All you have to do is to invoke your `Handle` method on the `ChatAssistant` dependency.

  💡 You can use `Context.ConnectionId` in the `ChatHub` for the `sessionId` parameter. The `ConnectionId` uniquely identifies the connected client.

Run the application, you should now be able to go to the Chat page (button in top right corner) and interact with the LLM.
