# Lab 3.3 - Human in the loop

In this lab, we will add the Human in the loop interaction between the agent and the user.

**Goal:** At the end of this lab, your agent can interact with you and use your input to decide what ride to book. 

> 👉🏻 We assume that you completed the hands-on lab 3.2
if you have not completed lab 3.2, you can use the provided completed lab 3.2 here: `HolSemanticKernel/exercises/module4/completed3.2`

Our agent is now able to call functions to retrieve available ride options. We explicity told it to provide us options and ask for permission before it can acutaly book a ride.
We now need to accomodate this interaction. We can do so by using the `AGentThread` class that captures the aget interactions. this includes user input, tool input and the mesages it produced itself. By creating the Thread and pass it into the Agent Invocation the agent will use this as the context in which it needs to do it's work. We are going to create the AgetThread, pass it into the invokations and isntruct the agent to give us a clear sign of completion, so we know when the interaction can end.
## Steps
1. Create the AgentThread class before we invoke the agent.

Just before the call where we invoke the agent, we now create a class of `ChatHistoryAgentThread`. We pass this thread now as part ot the agent invocation.

This looks as follows:
``` c#
var thread = new ChatHistoryAgentThread();
var agentResponse = agent.InvokeAsync(prompt, thread);
```

2. We can now use this thread for a second invocation, if we asume the dialog we had with the agent before. To test this out we will invoke the agent again aftere we printed the results, where we then solicit input first from the user.

After the call to print the results we use the `Console.ReadLine()` function to get input from the user. With this input we invoke the agent for a second time, so it can complete the work with our input.

The code now should look like this:
``` c#
var thread = new ChatHistoryAgentThread();
var agentResponse = agent.InvokeAsync(question, thread);

Console.WriteLine("******** RESPONSE 1 ***********");
await PrintResult(agentResponse);
var input = Console.ReadLine();

agentResponse = agent.InvokeAsync(input, thread);

Console.WriteLine("******** RESPONSE 2 ***********");
await PrintResult(agentResponse);

```
3. Improve the instructions to clearly state when the agent has reacht it's goal. we will define this in the instructions and ask it to provide us with a text marker that is easy to recognize and not common in normal user interaction. that way we can filter it out when we show this to the user and terminate our conversation if we find the marker.

Change the instructions of the agent to contain the following
