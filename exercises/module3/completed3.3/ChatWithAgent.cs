using Azure;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using System.Threading;

namespace modulerag
{
    internal class ChatWithAgent
    {

        public async Task let_agent_find_ride(string deploymentName, string endpoint, string apiKey)
        {

            var question =
            """
            I stay at the WestIn Seattle and the venue is the seattle cracken stadium.
            the Concert starts at 7:30 pm and is November 20th this year. 
            """;

            Console.WriteLine("******** Create the kernel ***********");
            IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
            var credential = new AzureKeyCredential(apiKey);
            kernelBuilder.AddOpenAIChatCompletion(deploymentName,new Uri(endpoint), apiKey);
            Kernel kernel = kernelBuilder.Build();
            Console.WriteLine("******** Create the agent ***********");
            var agent = CreateChatcompletionAgent(kernel);
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

        private ChatCompletionAgent CreateChatcompletionAgent(Kernel kernel)
        {
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


    }
}