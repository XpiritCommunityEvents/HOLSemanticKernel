# Lab 3.4 - Orchestration

In this lab, we create an agent orchestration between our previously created ride agent and a provided hotel agent.

**Goal:** At the end of this lab, you know how to create agent orchestrations using the Handoff orchestration available in semantic kernel. 

> 👉🏻 We assume that you completed the hands-on lab 3.3
if you have not completed lab 3.3, you can use the provided completed lab 3.3 here: `HolSemanticKernel/exercises/module4/completed3.3`

## Steps
1. In the previous lab you created an agent that con find you rides and book them. In the folder `HolSemanticKernel/exercises/module4/lab4.4/classes` you will find two classes. 

Please add these to your project. One class contains the `HotelBookingAgent` and the other the `HotelBookingFunctions` that agent uses to find available hotel nights and book a night that is selected by the user.

We are going to create a new funcion in the `ChatWithAgent` class, where we are going to create the interaction between agents. This new funcion is called `let_agent_find_ride_and_hotel` and we call this function from the program.cs We put the call to the previous function in comments.

the function body looks as follows:
``` c#
public async Task let_agent_find_ride_and_hotel(string deploymentName, string endpoint, string apiKey)
{

}
```

We will create a new question that we will pass to the agent to solve the bookign of a hotel and a ride from the hotel to the venue

``` c#
var question =
"""
I am going to a concert that is helt at the seattle cracken stadium. The Concert starts at 7:30 pm and is November 20th this year. 
""";
```

Next we are going to create two Agents. The first agent is the HotelBookingAgent and the second is the RideAgent and we are going to create a manual orchestration to solve the task to get a hotel and ride reservation.

the code for this looks as follows:
```c#
Console.WriteLine("******** Create the ride agent ***********");
var rideAgent = CreateChatcompletionAgent(config);
rideAgent.Kernel.ImportPluginFromType<RideInformationSystemService>();
Console.WriteLine("******** Create the hotel agent ***********");
var hotelAgent = HotelBookingAgent.CreateChatCompletionAgent(config);
hotelAgent.Kernel.ImportPluginFromType<HotelBookingFunctions>();
```

Next we set up the `ChatHistory` that we add to the `AgentThread`. This is the information which we use to feed the agents with enough context to complete their tasks.

```c#
// create the chat history that starts the agent thread
var history = new ChatHistory();
history.AddMessage(AuthorRole.User, question);

AgentThread thread = new ChatHistoryAgentThread(history);
```

In the previous lab we create a loop that ran untill an agent reached its goal. We are going to use that same code, but ow create a function that we can use for multiple agents. that way we can run an agent until its goal and then transfer to another agent with the same thread.

The function looks as follows:
```c#
private async Task RunUntilGoalReached(ChatCompletionAgent agent, AgentThread thread)
{
    var agentResponse = agent.InvokeAsync("", thread);

    await PrintResult(agentResponse);
    string input = null;
    while (!await IsGoalReached(agentResponse))
    {
        input = Console.ReadLine();

        agentResponse = agent.InvokeAsync(input, thread);

        await PrintResult(agentResponse);
    }
}
```

Now we can call this function first for the Hotel agent, since we like to get an hotel resevervation before we arrange a ride. then we do the same for the ride agent and provide it the AgentThread that was used to get the hotel information. 

now add the function calls to complete the function `let_agent_find_ride_and_hotel`

The final implementation looks as follows:
```c#
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
await RunUntilGoalReached(hotelAgent, thread);
Console.WriteLine("******** hotel agent done ***********"); 
await RunUntilGoalReached(rideAgent, thread);


Console.WriteLine("******** Done ***********");
```

Now run the program and interact with the agents to book an hotel and a ride from the hotel to the venue.

