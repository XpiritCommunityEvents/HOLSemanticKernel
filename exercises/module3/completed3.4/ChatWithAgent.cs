using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace modulerag;

internal class ChatWithAgent
{
    public async Task LetAgentFindRideAndHotel(IConfiguration config)
    {
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
    }

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

    public async Task LetAgentFindRide(IConfiguration config)
    {
        var question =
        """
        I stay at the WestIn Seattle and the venue is the Seattle Kraken stadium.
        the Concert starts at 7:30 pm and is November 20th this year. 
        """;

        Console.WriteLine("******** Create the agent ***********");
        var transportationAgent = CreateTransportationAgent(config);
        transportationAgent.Kernel.ImportPluginFromType<RideInformationSystemService>();
        Console.WriteLine("******** Start the agent ***********");

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
    }

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

    private ChatCompletionAgent CreateTransportationAgent(IConfiguration config)
    {
        var kernel = CreateKernel(config);

        var instructions = """
            You are an expert in finding transportation options from a given hotel location to the concert location.
            You will try to get the best options available for an affordable price. Make sure the customer will be there at least 30 minutes before the concert starts at the venue.
            You always suggest 3 options with different price ranges.
            You will ask for approval before you make the booking. 
            You are not allowed to make a booking without user confirmation!

            After you successfully booked the ride you will respond with [** GOAL REACHED **] in your message.            
            """; 

        ChatCompletionAgent agent = new()
        {
            Name = "TransportationAgent",
            Instructions = instructions,
            Description = "An agent that finds transportation options from hotel to concert location",
            Kernel = kernel,
            Arguments = new KernelArguments(new OpenAIPromptExecutionSettings()
            {
                FunctionChoiceBehavior = FunctionChoiceBehavior.Auto(),
            }),
        };

        return agent;
    }

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

    private static Kernel CreateKernel(IConfiguration config)
    {
        var model = config["OpenAI:Model"];
        var endpoint = config["OpenAI:EndPoint"];
        var token = config["OpenAI:ApiKey"];

        var kernelBuilder = Kernel
            .CreateBuilder()
            .AddOpenAIChatCompletion(model, new Uri(endpoint), token);

        var kernel = kernelBuilder.Build();
        return kernel;
    }
}