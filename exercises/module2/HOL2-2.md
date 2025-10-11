# Lab 2.1

In this lab, we will implement a simple tool that generates a random discount code when the user asks for it. We will provide the agent with the discount tool so it can invoke it by itself.

The tool we are going to create here is a simple hard coded random code generator. We will make a more sophisticated tool that accesses the GloboTicket database later today.

## Implement a GloboTicket discount tool

### Steps

1. Create a new class in your project named `DiscountTool` and add a new `public static` function called `GetDiscountCode`. Implement the function as follows:

    ```csharp
    public class DiscountTool
    {
        public static string GetDiscountCode(string userName = "guest")
        {
            var prefix = userName.ToUpper().Substring(0, Math.Min(4, userName.Length));
            var code = $"{prefix}{Random.Shared.Next(1000, 9999)}";
            return $"Here’s your GloboTicket code: GLOBO-{code}";
        }
    }
    ```

    As you can see it is just a plain C# method that returns a `string` value.

2. To provide the function as a "tool" to the agent, change the call to `CreateAIAgent()` to:

    ```csharp
    var agent = chatClient.CreateAIAgent(instructions, name: "GloboTicket Assistant",
        tools: [AIFunctionFactory.Create(DiscountTool.GetDiscountCode)]);
    ```

    Using the `AIFunctionFactory`, we wrap the `DiscountTool.GetDiscountCode` method in an `AIFunction` object, which is a subclass of `AITool`. Your method is now a tool that the LLM can call.

3. Set a breakpoint in the `GetDiscountCode` method and run the application in Debug mode. Ask for a discount. Does your `GetDiscountCode` method get called?

## Agent as a tool

In addition to functions, you can also implement full classes or even have an entire agent act as a tool for another agent. Let's try this.

### Steps

1. Create a second agent using the same chat client and provide it as an `AIFunction` to your GloboTicket agent:

    ```csharp
    var musicSnob =
        chatClient.CreateAIAgent(
            instructions:
            "You are a music snob. You only like the best bands. When asked, you will recommend the best bands that are similar to what the user likes.",
            name: "MusicRecommender",
            description: "Recommends music bands based on user preferences.");

    var agent = chatClient.CreateAIAgent(instructions, name: "GloboTicket Assistant",
        tools: [
            AIFunctionFactory.Create(GetDiscountCode),
            musicSnob.AsAIFunction()
        ]);
    ```

2. Run the application, tell the LLM your favorite artists and ask for recommendations. The application may take a bit longer to respond, but it should give you some tasteful suggestions.

3. Play around with the `musicSnob` instructions a little bit. For example, let it only recommend artists whose name starts with a certain letter.

## Inspect and prevent function calls using function invocation middleware

Let's say we don't want to give out any discounts to anonymous users. We don't have any user management built into this application, but let's only give discounts to users who tell the LLM their name.

We can use a _Function calling middleware_ to intercept the function call and inspect input and output of function calls. This way we can prevent unwanted information from being added to the conversation. Middleware is plugged into the call chain of the Agent Framework, just like middleware in an ASP.NET request pipeline. This allows you to perform any check or action _before_ and _after_ the function is invoked.

### Steps

1. Add a new class named `DiscountPolicyMiddleware` to the project.

2. In that class, implement a `public static` function called `DisallowAnonymousUsers`, with the following implementation:

    ```csharp
    public class DiscountPolicyMiddleware
    {
        public static async ValueTask<object?> DisallowAnonymousUsers(
            AIAgent agent,
            FunctionInvocationContext context,
            Func<FunctionInvocationContext, CancellationToken, ValueTask<object?>> next,
            CancellationToken cancellationToken)
        {
            // you can inspect the arguments here too to filter for unwanted data or stop execution

            var result = await next(context, cancellationToken);
            
            // you can inspect the results here too to filter for unwanted data
            return result;
        }
    }
    ```

    This is a standard method signature for a custom Function calling middleware. The `FunctionInvocationContext` parameter contains information about the function that is about to be called. The `Func<FunctionInvocationContext, CancellationToken, ValueTask<object?>> next` delegate lets you invoke the next step in the function invocation pipeline.

3. Let's add the following implementation:

    ```csharp
    public static async ValueTask<object?> DisallowAnonymousUsers(
        AIAgent agent,
        FunctionInvocationContext context,
        Func<FunctionInvocationContext, CancellationToken, ValueTask<object?>> next,
        CancellationToken cancellationToken)
    {
        if (context.Function.Name == "GetDiscountCode")
        {
            if (!context.Arguments.TryGetValue("userName", out var userName) 
                || ((JsonElement) userName!).GetString() == "guest")
            {
                return "No discounts for anonymous users allowed";
            }
        }

        var result = await next(context, cancellationToken);
        
        // you can inspect the results here too to filter for unwanted data
        return result;
    }
    ```

    Function call middleware is executed for any function call initiated by the LLM, so if you want to filter for a specific function, you need to inspect the `context.Function.Name` like in the sample above. When the `userName` is `"guest"`, we short cut the call by returning a string telling that discounts for anonymous users are not allowed. One thing you need to know is that the `Arguments` are passed to the function as `JsonElement`.

4. To register the middleware with the Agent Framework and have your agent use it, we must change the way the agent is constructed a bit. In your `Program.cs`, change the initialization of your `agent` variable to:

    ```csharp
    var agent = chatClient.CreateAIAgent(instructions,
            name: "GloboTicket Assistant",
            tools: [
                AIFunctionFactory.Create(DiscountTool.GetDiscountCode),
                musicSnob.AsAIFunction()
            ])
        .AsBuilder()
        .Use(DiscountPolicyMiddleware.DisallowAnonymousUsers)
        .Build();
    ```

    This code is a little bit more verbose, but we need the `AIAgentBuilder` infrastructure to inject our `DiscountPolicyMiddleware.DisallowAnonymousUsers` method into the pipeline.

5. Run the program again in debug mode and set a breakpoint in the `DisallowAnonymousUsers` code.

6. Ask the system for a discount without telling it your name. Does your filter get invoked with `"guest"` for the `userName` parameter? How does the system respond?

7. Now tell the LLM your name and ask for a discount again. Now you should see that the plugin is invoked and a discount is generated.

This implementation of `DisallowAnonymousUsers` returns a `string` telling the LLM that it cannot generate any discount code. But you can go one step further and halt any further execution of the agent run, something you may want to do if there is a serious security issue or risk of exposing secret information.

8. This is done by setting `context.Terminate` variable to `true` and return immediately from your middleware, like this:

    ```csharp
    public static async ValueTask<object?> DisallowAnonymousUsers(
        AIAgent agent,
        FunctionInvocationContext context,
        Func<FunctionInvocationContext, CancellationToken, ValueTask<object?>> next,
        CancellationToken cancellationToken)
    {
        if (context.Function.Name == "GetDiscountCode")
        {
            if (!context.Arguments.TryGetValue("userName", out var userName) 
                || ((JsonElement) userName!).GetString() == "guest")
            {
                context.Terminate = true;
                return null;
            }
        }
        
        var result = await next(context, cancellationToken);
        
        // you can inspect the results here too to filter for unwanted data
        return result;
    }
    ```

    Run your application with this version of the middleware and ask for a discount without sharing your name. You'll notice that the agent remains completely silent. This is because we terminated the agent run sequence in our middleware.

This concludes module 2. In this module, you got familiar with the basic building blocks of the Agent Framework: `AIAgent`,  `ChatClientAgentRunOptions`, `AgentThread`, `AIFunction`,  and Function calling middleware. In the next modules, we'll go deeper in to some more advanced scenarios.
