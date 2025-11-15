using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Agents.Orchestration.Sequential;
using Microsoft.SemanticKernel.Agents.Orchestration.Handoff;
#pragma warning disable SKEXP0110 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

namespace modulerag
{
    internal class ChatWithAgent
    {

        public async Task let_agent_find_ride(IConfiguration config)
        {

            var question =
            """
            I stay at the WestIn Seattle and the venue is the seattle cracken stadium.
            the Concert starts at 7:30 pm and is November 20th this year. 
            """;

            Console.WriteLine("******** Create the agent ***********");
            var agent = CreateChatcompletionAgent(config);
            agent.Kernel.ImportPluginFromType<RideInformationSystemService>();
            Console.WriteLine("******** Start the agent ***********");
            var thread = new ChatHistoryAgentThread();
            var agentResponse = agent.InvokeAsync(question, thread);

            Console.WriteLine("******** RESPONSE 1 ***********");
            await PrintResult(agentResponse);
            string input = null;
            while (!await IsGoalReached(agentResponse))
            {
                input = Console.ReadLine();

                agentResponse = agent.InvokeAsync(input, thread);

                Console.WriteLine("******** RESPONSE ***********");
                await PrintResult(agentResponse);

            }
            Console.WriteLine("******** Terminating, goal reached ***********");

        }

        public async Task let_agent_find_ride_and_hotel(IConfiguration config)
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
            await RunUntilGoalReached(hotelAgent, thread);
            Console.WriteLine("******** hotel agent done ***********"); 
            await RunUntilGoalReached(rideAgent, thread);


            Console.WriteLine("******** Done ***********");

        }

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

        private ChatCompletionAgent CreateChatcompletionAgent(IConfiguration config)
        {
            Kernel kernel = CreateKernel(config);
            var instructions = """
            You are an expert in finding transportation options from a given hotel location to the concert location.
            You will try to get the best options available for an afordable price.Make sure the customer will be there at least 30 minutes
            before the concert starts at the venue. You always suggest 3 options with different price ranges.
            You will ask for approval before you make the booking. 
            You are not allowed to make a booking without user confirmation!

            After you succesfully booked the ride you will respond with [** GOAL REACHED **] in your message.            
            """; 

            ChatCompletionAgent agent = new()
            {
                Name = "TransportationAgent",
                Instructions = instructions,
                Description = "An agent that finds transportation options from hotel to concert location",
                Kernel = kernel,
                Arguments = new KernelArguments(new AzureOpenAIPromptExecutionSettings()
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
                Console.WriteLine($"Thread data: {item.Thread.ToString()}");
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
}