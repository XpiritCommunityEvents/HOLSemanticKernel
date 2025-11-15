# Lab 3.4 - Orchestration

In this lab, we create an agent orchestration between our previously created `TransportationAgent` and a pre-made `HotelReservationAgent` that we provide for you.

**Goal:** At the end of this lab, you know how to create agent orchestrations using the `Handoff Orchestration` available in `SemanticKernel`. 

> 👉🏻 We assume that you completed the hands-on lab 3.3
If you have not completed lab 3.3, you can use the provided completed lab 3.3 here: `exercises/module4/completed3.3`

## Steps
1. In the previous lab you created an agent that can find you taxi rides and book them. In the folder `exercises/module4/lab4.4/classes` you will find two other pre-made classes:

- `HotelBookingAgent`: an agent that can find and book hotel rooms
- `HotelBookingFunctions`: a plugin for the `HotelBookingAgent` that provides the agent with knowledge about hotel room availability and the ability to book a room that is selected by the user

Please add these to your project.

We are going to create a new funcion in the `ChatWithAgent` class, where we are going to create the interaction between agents. This new funcion is called `LetAgentFindRideAndHotel` and we call this function from the `Program.cs`. We put the call to the previous `LetAgentFindRide` function in comments.

The function body looks as follows:

```csharp
public async Task LetAgentFindRideAndHotel(IConfiguration config)
{

}
```

We will create a new question that we will pass to the agent to solve the booking of a hotel and a ride from the hotel to the venue.

```csharp
var question =
"""
I am going to a concert that is held at the Seattle Kraken Stadium. The Concert starts at 7:30 pm and is November 20th this year. 
""";
```

Next, we are going to create two agents. The first agent is the `HotelBookingAgent` and the second is the `TransportationAgent` and we are going to create a manual orchestration to solve the task to get a hotel and ride reservation.

The code for this looks as follows:

```csharp
Console.WriteLine("******** Create the ride agent ***********");
var rideAgent = CreateTransportationAgent(config);
rideAgent.Kernel.ImportPluginFromType<RideInformationSystemService>();

Console.WriteLine("******** Create the hotel agent ***********");
var hotelAgent = HotelBookingAgent.CreateChatCompletionAgent(config);
hotelAgent.Kernel.ImportPluginFromType<HotelBookingFunctions>();
```

Next, we set up the `ChatHistory` that we add to the `AgentThread`. This is the information which we use to feed the agents with enough context to complete their tasks.

```csharp
// create the chat history that starts the agent thread
var history = new ChatHistory();
history.AddMessage(AuthorRole.User, question);

AgentThread thread = new ChatHistoryAgentThread(history);
```

In the previous lab we create a loop that ran until an agent reached its goal. We are going to use that same code, but now create a function that we can use for multiple agents. That way we can run an agent until its goal is reached and then transfer to another agent with the same thread.

The function looks as follows:

```csharp
private async Task RunUntilGoalReached(ChatCompletionAgent agent, AgentThread thread)
{
    var agentResponse = agent.InvokeAsync("", thread);

    await PrintResult(agentResponse);
    while (!await IsGoalReached(agentResponse))
    {
        var input = Console.ReadLine();

        agentResponse = agent.InvokeAsync(input, thread);

        await PrintResult(agentResponse);
    }
}
```

Now we can call this function first for the `HotelBookingAgent` agent, since we like to get an hotel reservation before we arrange a ride. Then we do the same for the ride agent and provide it the `AgentThread` that was used to get the hotel information. 

Now add the function calls to complete the function `LetAgentFindRideAndHotel`

The final implementation looks as follows:

```c#
var question =
"""
I am going to a concert that is held at the Seattle Kraken Stadium. The Concert starts at 7:30 pm and is November 20th this year. 
""";

Console.WriteLine("******** Create the ride agent ***********");
var rideAgent = CreateTransportationAgent(config);
rideAgent.Kernel.ImportPluginFromType<RideInformationSystemService>();

Console.WriteLine("******** Create the hotel agent ***********");
var hotelAgent = HotelBookingAgent.CreateChatCompletionAgent(config);
hotelAgent.Kernel.ImportPluginFromType<HotelBookingFunctions>();

// create the chat history that starts the agent thread
var history = new ChatHistory();
history.AddMessage(AuthorRole.User, question);

AgentThread thread = new ChatHistoryAgentThread(history);

await RunUntilGoalReached(hotelAgent, thread);
Console.WriteLine("******** hotel agent done ***********"); 
await RunUntilGoalReached(rideAgent, thread);

Console.WriteLine("******** Done ***********");
```

Now run the program and interact with the agents to book an hotel and a ride from the hotel to the venue.

This concludes Lab 3.4.