# Lab 3.1 - Using Agents

In this lab, we will explore the use of agents as a way to interact with LLM's.

## Create an Agent that can book rides

**Goal:** At the end of this lab, you should have an agent that can find affordable rides for you and can also book them at a booking provider.

> 👉🏻 We assume that you use a clean startup solution that we created that contains the boilerplate to get you started. You can find this in `exercises/module4/start`.

### Steps

1. Open the folder in your codespace and load the solution `module-agent-start.sln`:

In the solution you find two classes. `Program.cs`, which is the entrypoint of the console application and `ChatWithAgent.cs`

The `Program.cs` is similar as in the other exercises where we read the configuration file and user secrets, create an instance of the class `ChatWithAgent` and we call the method we want to execute.

The boilerplate for the method `LetAgentFindRide` is created and you are now going to create an Agent to first have a similar conversation as you had with the `IChatCompletion` interface in the previous excercises.

When you run the application the output should look as follows:

```console
******** Create the agent ***********
******** Start the agent ***********
******** RESPONSE ***********
```

For your convenience, we already gave you the code for initializing the `Kernel` instance in the `Program.cs` and since we use the same `UserSecretsId` for all or C# projects, the `OpenAI:ApiKey` secret should be available for this lab as well. You can validate if this works by simply adding one line in `LetAgentFindRide` for testing purposes and run the program again:

```c#
var result = await kernel.InvokePromptAsync("what color is the sky?");
Console.WriteLine(result);
```

3. Create the agent with the `kernel` object provided to the `LetAgentFindRide` method.

Now add a function where you pass in the kernel object and return a `ChatCompletionAgent`, name the fuction `CreateTransportationAgent`:

```csharp
private ChatCompletionAgent CreateTransportationAgent(Kernel kernel)
{

}
```

We start by defining the instructions for the agent. The agent we want to create is one that can find us a Ride from our hotel to the concert venue. Feel free to experiment with your own instructions, these are the instructions we used when creating this hands-on lab:

```csharp
var instructions = """
    You are an expert in finding transportation options from a given hotel location to the concert location.
    You will try to get the best options available for an affordable price. Make sure the customer will be there at least 30 minutes before the concert starts at the venue.
    You always suggest 3 options with different price ranges.
    You will ask for approval before you make the booking.
    """;
```

A `ChatCompletionAgent` can be constructed by providing it information during construction. It needs a `name`, `description` and a `kernel` object at a minimum.

> :warning: Note that using whitespace in the name of the agent, or leaving out the description will result in failure when using the agent.

The code for creating the agent should look as follows:

```csharp
ChatCompletionAgent transportationAgent =
    new()
    {
        Name = "TransportationAgent",
        Instructions = instructions,
        Description = "An agent that finds transportation options from hotel to concert location",
        Kernel = kernel,
    };
```

> 💡 If you want to get logging information about what the agent is doing, you can add your own `LoggerFactory` to the agent. This is similar to adding logging to the kernel object. Note that providing a logger to the kernel, will not give you log information about what the agent is doing. It will only show information about the usage of the kernel object itself and calls to the LLM. Adding a logger is done by specifying the logger in the construction of the agent like this:

```c#
        ChatCompletionAgent transportationAgent =
            new()
            {
                Name = "TransportationAgent",
                Instructions = instructions,
                Description = "An agent that finds transportation options from hotel to concert location",
                Kernel = kernel,
                LoggerFactory = LoggerFactory.Create(builder =>
                {
                    // Add Console logging provider
                    builder.AddConsole().SetMinimumLevel(LogLevel.Trace);
                })
            };
```

Now you have the agent object, which you can return to complete the function.

4. Create the agent and ask it to do something for you.

Now call the `CreateTransportationAgent` function and use this agent to ask it to do work for you. For this you can call the agent function `InvokeAsync`. In `LetAgentFindRide`, add the following code:

```charp
var question =
"""
I stay at the WestIn Seattle and the venue is the Seattle Kraken Stadium.
The concert starts at 7:30 pm and is November 20th this year. 
""";

var agent = CreateTransportationAgent(kernel);

var agentResult = agent.InvokeAsync(question);
```

Here you can immediately observe that the return value of the `InvokeAsync` method is a response that contains much more information. It returns `IAsyncEnumerable<AgentResponseItem<ChatMessageContent>>` which is not a response with only `ChatMessageContent`.

The `AgentResponseItem` contains for example information about the `AgentThread` that is created to facilitate an agent orchestration. We like to print this information, so we can see the results.

For this we create a `PrintResult` function that uses an `async foreach` loop to print each item.

The function to print the result looks as follows:

```csharp
private static async Task PrintResult(IAsyncEnumerable<AgentResponseItem<ChatMessageContent>> agentResponse)
{
    await
    foreach (var item in agentResponse)
    {
        Console.WriteLine($"Thread: {item.Thread.Id}");
        Console.WriteLine($"Thread data: {item.Thread}");
        Console.WriteLine($"Author: {item.Message.AuthorName}");
        Console.WriteLine($"Message:{item.Message}");
    }
}
```

Your call to the agent and printing the result should look as follows:

```csharp
var agentresult = agent.InvokeAsync(question);
Console.WriteLine("******** RESPONSE ***********");
await PrintResult(agentresult);
```

Experiment with different information in the question to see how the agent responds.

The output should look similar to:

``` console
******** Create the kernel ***********
******** Create the agent ***********
******** Start the agent ***********
******** RESPONSE ***********
Thread: 9716e329c6a0438d89cacad2ce3230da
Thread data: Microsoft.SemanticKernel.Agents.ChatHistoryAgentThread
Author: TransportationAgent
Message:Thank you for providing the details! Let me identify the best transportation options for you. To ensure you'll arrive at the Seattle Kraken Stadium (Climate Pledge Arena) at least 30 minutes before the concert (so by 7:00 PM), I'll aim for an arrival time around 6:50 PM. Here are three options with different price ranges:

---

### Option 1: Budget-Friendly - Public Transit (King County Metro or Monorail)
- **Cost**: Approximately **$2.75 per person** (one-way King County Metro fare) or $3.75 for Downtown Monorail.
- **Details**: Take a Quick Bus on **Metro Route 8 or D Line** from near Westin or hop directly to Downton skywalk bridge monorail stops .It's an estimated 10-20 ride before nearing these location all upto weather .
```

This concludes Lab 3.1