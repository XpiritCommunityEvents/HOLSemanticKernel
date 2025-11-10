using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Agents.Magentic;
using Microsoft.SemanticKernel.Agents.Orchestration;
using Microsoft.SemanticKernel.Agents.Runtime.InProcess;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using System.Text;
using System.Text.Json;
using UseSemanticKernelFromNET.Plugins;

#pragma warning disable SKEXP0110 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

namespace agent_demo01
{
    public class PlanMyVisit
    {
        private readonly LogLevel logLevel = LogLevel.Information;

        // goal:
        // Create a personalized visit plan containing parking, bag policy, timing, accessibility and hotel reservation
        public async Task<bool> PlanVisit(TicketInformation info, string deploymentName, string endpoint, string apiKey, string magenticModel)
        {
            var kernel = CreateKernelWithChatCompletion(deploymentName, endpoint, apiKey);

            var settings = new AzureOpenAIPromptExecutionSettings()
            {
                FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
            };

            ChatCompletionAgent conciergeAgent =
              new()
              {
                  Name = "Concierge",
                  Instructions = """
                  You coordinate the booking of hotels and transportation. You critique the provided solutions until you are 
                  happy with the results. this is a hotel nights booked and transportation arranged for the customer.
                  You ask the customer to confirm the purchase of the itinerary and after confirmation you book the various items.
                  """,
                  Description = "An agent that orchestrates a visit to a music concert including hotel, dinner and transportation",
                  Kernel = kernel,
                  LoggerFactory = LoggerFactory.Create(builder =>
                  {
                      // Add Console logging provider
                      builder.AddConsole().SetMinimumLevel(logLevel);
                  }),
                  Arguments = new KernelArguments(settings)
              };

            ChatCompletionAgent hotelReservationAgent =
              new()
              {
                  Name = "HotelReservationAgent",
                  Instructions = """
                  You are an expert in finding hotel rooms close to music concert locations.You provide some options what you have found and
                  wait for the Concierge to approve the booking of the hotel rooms you suggested. You always suggest 3 options with different price ranges.
                  """,
                  Description = "An agent that finds hotel rooms close to the concert location",
                  Kernel = kernel,
                  LoggerFactory = LoggerFactory.Create(builder =>
                  {
                      // Add Console logging provider
                      builder.AddConsole().SetMinimumLevel(logLevel);
                  }),
                  Arguments = new KernelArguments(settings)
              };

            ChatCompletionAgent transportationAgent =
              new()
              {
                  Name = "TransportationAgent",
                  Instructions = """
                  You are an expert in finding transportation from a given hotel location to the concert location. You will try to get the best option.
                  that ensures the customers are at least 30 minutes before the concert starts at the venue and you search for options that are most convenient 
                  and best value for price. You always suggest 3 options with different price ranges. the moment the concierge approves your selection you are allowed to 
                  book the transportation.
                  """,
                  Description = "An agent that finds transportation options from hotel to concert location",
                  Kernel = kernel,
                  LoggerFactory = LoggerFactory.Create(builder =>
                  {
                      // Add Console logging provider
                      builder.AddConsole().SetMinimumLevel(logLevel);
                  }),
                  Arguments = new KernelArguments(settings)
              };

            var InitialChatMessage = new ChatMessageContent()
            {
                Role = AuthorRole.User,
                Content =
              $"{info.EventName} is held in {info.Location} and the artist is {info.Artist}. the date of the concert is {info.EventDate.ToString("dd-MM-yyyy")}"
            };

            var monitor = new OrchestrationMonitor();

            // create the agent orchestration setup, so they can chat with each other and then provide a final result.
            StandardMagenticManager manager =
                   new(
                       kernel.GetRequiredService<IChatCompletionService>(),
                       new AzureOpenAIPromptExecutionSettings()
                   )
                   {
                       InteractiveCallback = () =>
                       {
                           Console.WriteLine("\n# Press Enter to continue the orchestration...");
                           var userinput = Console.ReadLine();
                           return ValueTask.FromResult(new ChatMessageContent()
                           {
                               Role = AuthorRole.User,
                               Content = userinput
                           });
                       },
                       MaximumInvocationCount = 5,
                   };

            MagenticOrchestration orchestration =
                new(manager, conciergeAgent, transportationAgent, hotelReservationAgent)
                {
                    LoggerFactory = LoggerFactory.Create(builder =>
                    {
                        // Add Console logging provider
                        builder.AddConsole().SetMinimumLevel(logLevel);
                    }),
                    //ResponseCallback = monitor.ResponseCallback,
                    StreamingResponseCallback =  monitor.StreamingResultCallback,
                    Description = "Orchestration to plan a visit to a music concert including hotel and transportation",
                    Name = "PlanMyVisitOrchestration",
                };

            // Start the runtime
            InProcessRuntime runtime = new();
            await runtime.StartAsync();

            OrchestrationResult<string> result = await orchestration.InvokeAsync(InitialChatMessage.Content, runtime);

            Console.WriteLine("# Orchestration is running...");

            var response = await result.GetValueAsync(TimeSpan.FromSeconds(300));

            Console.WriteLine("# Orchestration is done...");

            //write the orchestration history
            var results = monitor.History;

            foreach(var message in results)
                Console.WriteLine(message.ToString());

            await runtime.RunUntilIdleAsync();
            return true;
        }
       
        public Kernel CreateKernelWithChatCompletion(string deploymentName, string endpoint, string apiKey)
        {
            IKernelBuilder kernelBuilder = Kernel.CreateBuilder();

            kernelBuilder.AddAzureOpenAIChatCompletion(deploymentName, endpoint, apiKey);
            //kernelBuilder.AddAzureAIInferenceChatCompletion(deploymentName, apiKey, new Uri(endpoint));

            kernelBuilder.Services.AddLogging(
                                 s => s.AddConsole().SetMinimumLevel(logLevel));

            // add plugin BEFORE building the kernel
            kernelBuilder.Plugins.AddFromType<HotelPlugin>();

            Kernel kernel = kernelBuilder.Build();

            return kernel;
        }

        protected static void WriteStreamedResponse(IEnumerable<StreamingChatMessageContent> streamedResponses)
        {
            string? authorName = null;
            AuthorRole? authorRole = null;
            StringBuilder builder = new();

            foreach (StreamingChatMessageContent response in streamedResponses)
            {
                authorName ??= response.AuthorName;
                authorRole ??= response.Role;

                if (!string.IsNullOrEmpty(response.Content))
                {
                    builder.Append(response.Content);
                }
            }

            if (builder.Length > 0)
            {
                System.Console.WriteLine($"\n# STREAMED {authorRole ?? AuthorRole.Assistant}{(authorName is not null ? $" - {authorName}" : string.Empty)}: {builder}\n");
            }
        }

        protected sealed class OrchestrationMonitor
        {
            public List<StreamingChatMessageContent> StreamedResponses = [];

            public ChatHistory History { get; } = [];

            public ValueTask ResponseCallback(ChatMessageContent response)
            {
                this.History.Add(response);
                Console.WriteLine(response);
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
    }

}
