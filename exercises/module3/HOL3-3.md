# Lab 3.3 - Human-in-the-Loop

In this lab, we will add the Human-in-the-Loop interaction between the agent and the user.

**Goal:** At the end of this lab, your agent can interact with you and use your input to decide what ride to book. 

> 👉🏻 We assume that you completed the hands-on lab 3.2
If you have not completed lab 3.2, you can use the provided completed lab 3.2 here: `exercises/module4/completed3.2`

Our agent is now able to call functions to retrieve available ride options. We explicity told it to provide us options and ask for permission before it can actually book a ride.

We now need to accomodate this interaction. We can do so by using the `ChatHistoryAgentThread` class that captures the agent interactions. This includes user input, tool input and the messages it produced itself. By creating the `ChatHistoryAgentThread` and pass it into the agent invocation, the agent will use this as the context in which it needs to do its work. We are going to create the `ChatHistoryAgentThread`, pass it into the invocations and instruct the agent to give us a clear sign of completion, so we know when the interaction can end.

## Steps

1. Create the `ChatHistoryAgentThread` instance before we invoke the agent.

Just before the call where we invoke the agent, we now create a instance of `ChatHistoryAgentThread`. We pass this thread as part ot the agent invocation.

This looks as follows:

```csharp
var thread = new ChatHistoryAgentThread();
var agentresult = transportationAgent.InvokeAsync(question, thread);
```

2. We can now use this thread for a second invocation, just like we did with the `ChatHistory` in lab 2. To test this out, we will invoke the agent again after printing the results. After that, we will solicit input from the user.

After the call to `PrintResult`, we use `Console.ReadLine()` to get input from the user. With this input we invoke the agent for a second time, so it can complete the work with our input.

The code now should look like this:

```csharp
var thread = new ChatHistoryAgentThread();
var agentresult = transportationAgent.InvokeAsync(question, thread);

Console.WriteLine("******** RESPONSE 1 ***********");
await PrintResult(agentresult);

var input = Console.ReadLine();
agentresult = transportationAgent.InvokeAsync(input, thread);

Console.WriteLine("******** RESPONSE 2 ***********");
await PrintResult(agentresult);

```

3. Improve the instructions to clearly state when the agent has reached its goal. We will define this in the instructions and ask it to provide us with a text marker that is easy to recognize and not common in normal user interaction. That way, we can filter it out when we show this to the user and terminate our conversation if we find the marker.

Change the instructions of the agent to contain the following

```csharp
var instructions = """
    You are an expert in finding transportation options from a given hotel location to the concert location.
    You will try to get the best options available for an affordable price. Make sure the customer will be there at least 30 minutes before the concert starts at the venue.
    You always suggest 3 options with different price ranges.
    You will ask for approval before you make the booking. 
    You are not allowed to make a booking without user confirmation!

    After you successfully booked the ride you will respond with [** GOAL REACHED **] in your message.            
    """; 
```

Now we create a function that can determine if we reached our goal as follows:

```csharp
private async Task<bool> IsGoalReached(IAsyncEnumerable<AgentResponseItem<ChatMessageContent>> agentResponse)
{
    await foreach(var item in agentResponse)
    {
        if(item.Message.Content.Contains("[** GOAL REACHED **]"))
        {
            return true;
        }
    }
    return false;
}
```

Instead of doing two invocations, we now create a loop that will continue the conversation with the user, until the goal is accomplished.

This looks as follows:

```csharp
var thread = new ChatHistoryAgentThread();
var agentresult = transportationAgent.InvokeAsync(question, thread);

Console.WriteLine("******** RESPONSE 1 ***********");
await PrintResult(agentresult);

while (!await IsGoalReached(agentresult))
{
    var input = Console.ReadLine();

    agentresult = transportationAgent.InvokeAsync(input, thread);

    Console.WriteLine("******** RESPONSE ***********");
    await PrintResult(agentresult);
}
Console.WriteLine("******** Terminating, goal reached ***********");
```

Now run the program and enter the dialog with the agent. If it gets back to you that it can't find more results, ask it e.g. to try harder, and you will see it starts doing more function calls to get more ride options.

This concludes Lab 3.3.