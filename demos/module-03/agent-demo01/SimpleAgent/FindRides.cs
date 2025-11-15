using agent_demo01.Plugins;
using Azure;
using Azure.AI.OpenAI;
using Azure.Core;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using UseSemanticKernelFromNET.Plugins;

namespace agent_demo01
{
    public class SimpleAgent
    {
       
        public async Task<bool> FindRides(string deploymentName, string endpoint, string apiKey)
        {

            var kernel = CreateKernelWithChatCompletion(deploymentName, endpoint, apiKey);

            var agent = CreateChatCompletionAgent(kernel);
            agent.Kernel.ImportPluginFromType<TransportationBookings>();
            var thread = new ChatHistoryAgentThread();

            var prompt = """
                I stay at the WestIn Seattle and the venue is the seattle cracken stadium.
                the Concert starts at 7:30 pm and is November 20th this year.
                """;
            var agentResponse = agent.InvokeAsync(prompt, thread);
            await PrintResult(thread, agentResponse);
            var input = Console.ReadLine();

            agentResponse = agent.InvokeAsync(input, thread);
            await PrintResult(thread, agentResponse);
            return true;
        }

        private static async Task PrintResult(ChatHistoryAgentThread thread, IAsyncEnumerable<AgentResponseItem<ChatMessageContent>> agentResponse)
        {
            await
            foreach (var item in agentResponse)
            {
                Console.WriteLine($"Thread: {item.Thread.Id}");
                Console.WriteLine($"Thread data: {item.Thread.ToString()}");
                Console.WriteLine($"Author: {item.Message.AuthorName}");
                Console.WriteLine($"Message:{item.Message}");
            }
          
            foreach (var historyItem in thread.ChatHistory)
            {
                Console.WriteLine($"***** Agent thread info *****");
                Console.WriteLine($"Thread: {thread.Id}");
                Console.WriteLine($"Role: {historyItem.Role}");
                Console.WriteLine($"Message: {historyItem.Content}");

            }
        }

        public Kernel CreateKernelWithChatCompletion(string deploymentName, string endpoint, string apiKey)
        {
            IKernelBuilder kernelBuilder = Kernel.CreateBuilder();

            //kernelBuilder.AddAzureOpenAIChatCompletion(deploymentName, endpoint, apiKey);
            var credential = new AzureKeyCredential(apiKey);

            var client = new AzureOpenAIClient(new Uri(endpoint), credential);
            kernelBuilder.AddAzureOpenAIChatCompletion(deploymentName, client);
            Kernel kernel = kernelBuilder.Build();

            return kernel;
        }

        private ChatCompletionAgent CreateChatCompletionAgent(Kernel kernel)
        {
            ChatCompletionAgent transportationAgent =
            new()
            {
                Name = "TransportationAgent",
                Instructions = """
            You are an expert in finding transportation options from a given hotel location to the concert location.
            You will try to get the best options available for an afoordable price.Make sure the customer will be there at least 30 minutes
            before the concert starts at the venue. You always suggest 3 options with different price ranges.
            You will ask for approval before you make the booking
            """,
                Description = "An agent that finds transportation options from hotel to concert location",
                Kernel = kernel,
                LoggerFactory = LoggerFactory.Create(builder =>
                {
                    // Add Console logging provider
                    builder.AddConsole().SetMinimumLevel(LogLevel.Trace);
                }),
                Arguments = new KernelArguments(new AzureOpenAIPromptExecutionSettings()
                {
                    FunctionChoiceBehavior = FunctionChoiceBehavior.Auto(),
                }),
            };
            return transportationAgent;
        }
    }
}