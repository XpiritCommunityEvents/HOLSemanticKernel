## :clock1: If time permits
### Create an agent orchestration using HandoffOrchestration

In stead of creating our own orchestration by passing the AgentThread to various agents and waiting for their completions, we now are going to use a standard Semantic Kernel Orchestration.

Since we need human interaction to ensure bookings are done onlywih consent of the user, we are going to use the `HandOffOrchestration`

Duplicate the function you created in the previous step and name this function `let_agent_find_ride_and_hotel_with_orchestrator` and remove the last part of the implementation where we run the agents untill they reach their goal.

You now should have a function that looks as follows:
``` c#
public async Task let_agent_find_ride_and_hotel_with_orchestrator(IConfiguration config)
{
    var question =
    """
    I am going to a concert that is helt at the seattle cracken stadium. The Concert starts at 7:30 pm and is November 20th this year. 
    """;

    Console.WriteLine("******** Create the ride agent ***********");
    var rideAgent = CreateChatcompletionAgent(config);
    rideAgent.Kernel.ImportPluginFromType<RideInformationSystemService>();
    Console.WriteLine("******** Create the hotel agent ***********");
    var hotelAgent = HotelBookingAgent.CreateChatCompletionAgent(config);
    hotelAgent.Kernel.ImportPluginFromType<HotelBookingFunctions>();
    // create the chat history that starts the agent thread
    var history = new ChatHistory();
    history.AddMessage(AuthorRole.User, question);

    AgentThread thread = new ChatHistoryAgentThread(history);

    // Orchestration will come below    

}

```

### Who is going to approve the hotel and ride bookings?
We want this system to run autonomous, so we need to have another agent that can approve the suggestions. For this we create an Concierge Agent. This is the same as all the other agents, now with the following instructions:

```c#
Instructions = """
You are an expert coordinating the booking of hotels and rides from and to the hotel.
You are allowed to approve a booking without user interaction.
You always balance price with convinience and try to make the trip as enjoyable as possible for the customer.

You use other agents to do the actual interaction with the end user.
You can approve suggested hotels and rides.
After you succesfully booked the hotel and a ride you will respond with [** GOAL REACHED **] in your message.            
""",
```

The orchestrator that we are going to use also needs a couple of things to manage the agents. For this we have a helper class that we can use. It is beyond the scope of this lab to go into all the details here, simply use this class that we can reference in our orchestrtor:

```c#
protected sealed class OrchestrationMonitor
{
    public List<StreamingChatMessageContent> StreamedResponses = [];

    public ChatHistory History { get; } = [];

    public ValueTask ResponseCallback(ChatMessageContent response)
    {
        this.History.Add(response);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Response callback called with response:\n {response}");
        Console.ResetColor();
        return ValueTask.CompletedTask;
    }

    public ValueTask StreamingResultCallback(StreamingChatMessageContent streamedResponse, bool isFinal)
    {
        this.StreamedResponses.Add(streamedResponse);

        if (isFinal)
        {
            WriteStreamedResponse(this.StreamedResponses);
            this.StreamedResponses.Clear();
        }

        return ValueTask.CompletedTask;
    }
}
```

Now we can create the instance of the orchestrator. That looks as follows:

```c#
var monitor = new OrchestrationMonitor();
var handoffs = OrchestrationHandoffs.StartWith(concierge)
    .Add(concierge, hotelAgent, rideAgent)
    .Add(concierge, hotelAgent, "Ask this agent to find and book hotel rooms")
    .Add(concierge, rideAgent, "Ask this agent to find a ride for a specific hotel location")
    .Add(hotelAgent, concierge, "transfer this agent when the hotel booking is done")
    .Add(rideAgent, concierge, "transfer this agent when the ride booking is done");            
    var orchestration = new HandoffOrchestration(handoffs,concierge, hotelAgent, rideAgent)
    {
        Name = "HotelAndRideBookingOrchestration",
        InteractiveCallback = () =>
        {

            Console.WriteLine("\n# Handoff occurred. Please provide input to continue the orchestration...");
            string input = Console.ReadLine();
            return ValueTask.FromResult(new ChatMessageContent(AuthorRole.User, input));
        },
        //LoggerFactory = LoggerFactory.Create(builder =>
        //{
        //    // Add Console logging provider
        //    builder.AddConsole().SetMinimumLevel(LogLevel.Trace);
        //}),
        ResponseCallback = monitor.ResponseCallback,
        Description = "Orchestration to book hotel and ride for concert using multiple agents"
    };

```

The final step is that we need to invoke the orchestration to run.
For this we need an runtime process that can host the orchestration. For this we create an `InProcessRuntime` instance and we pass that into the orchestration invocation. This will handoff the work to the runtime that will then run on a seperate thread to do the agentic work.

This code looks as follows:
``` c#
InProcessRuntime runtime = new();
await runtime.StartAsync();

OrchestrationResult<string> result = await orchestration.InvokeAsync(InitialChatMessage.Content, runtime);

Console.WriteLine("# Orchestration is running...");

var response = await result.GetValueAsync(TimeSpan.FromSeconds(300));

Console.WriteLine("# Orchestration is done...");


Console.WriteLine("# Orchestration result...");
Console.WriteLine(response);

await runtime.RunUntilIdleAsync();
```
>:construction: Note that these orchestrations are still work in progress. At the moment the results you see may vary and depend highly on the response you get from the LLM's.
Try experimenting with a few diffrent models by making changes to the appsettings.config file and switch models and see the results.