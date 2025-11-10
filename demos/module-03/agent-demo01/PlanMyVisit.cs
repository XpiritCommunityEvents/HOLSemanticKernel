using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel;

using OpenAI;
using System.ClientModel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Agents.Orchestration.Handoff;
using Microsoft.SemanticKernel.Agents.Runtime.InProcess;

using Microsoft.SemanticKernel.Agents.Orchestration;
using Amazon.S3.Model;
using System.Threading;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.SemanticKernel.Agents.Orchestration.GroupChat;
using Microsoft.SemanticKernel.Agents.Magentic;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using UseSemanticKernelFromNET.Plugins;
#pragma warning disable SKEXP0110 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

namespace agent_demo01
{
    public class PlanMyVisit
    {
        // goal:
        // Create a personalized visit plan containing parking, bag policy, timing, accessibility and hotel reservation
        public async Task<bool> PlanVisit(TicketInformation info, string deploymentName, string endpoint, string apiKey, string magenticModel)
        {
            var client = new OpenAIClient(new ApiKeyCredential(apiKey), 
                new OpenAIClientOptions { Endpoint = new Uri(endpoint) });

            //IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
            //kernelBuilder.AddOpenAIChatCompletion(deploymentName, client);
            //kernelBuilder.Services.AddLogging(
            //                     s => s.AddConsole().SetMinimumLevel(LogLevel.Trace));
            //Kernel kernel = kernelBuilder.Build();

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
                  Kernel = CreateKernelWithChatCompletion(deploymentName, endpoint, apiKey),
                  LoggerFactory = LoggerFactory.Create(builder =>
                  {
                      // Add Console logging provider
                      builder.AddConsole();
                  }),
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
                  Kernel = CreateKernelWithChatCompletion(deploymentName, endpoint, apiKey),
                  LoggerFactory = LoggerFactory.Create(builder =>
                  {
                      // Add Console logging provider
                      builder.AddConsole();
                  }),
              };
             hotelReservationAgent.Kernel.Plugins.AddFromObject(new HotelPlugin());

            ChatCompletionAgent transportationAgent =
              new()
              {
                  Name = "transportationAgent",
                  Instructions = """
                  You are an expert in finding transportation from a given hotel location to the concert location. You will try to get the best option.
                  that ensures the customers are at least 30 minutes before the concert starts at the venue and you search for options that are most convenient 
                  and best value for price. You always suggest 3 options with different price ranges. the moment the concierge approves your selection you are allowed to 
                  book the transportation.
                  """,
                  Description = "An agent that finds transportation options from hotel to concert location",
                  Kernel = CreateKernelWithChatCompletion(deploymentName, endpoint, apiKey),
                  LoggerFactory = LoggerFactory.Create(builder =>
                  {
                      // Add Console logging provider
                      builder.AddConsole();
                  })
              };

            var InitialChatMessage = new ChatMessageContent()
            {
                Role = AuthorRole.User,
                Content =
              $"{info.EventName} is held in {info.Location} and the artist is {info.Artist}. the date of the concert is {info.EventDate.ToString("dd-MM-yyyy")}"
            };

            var monitor = new OrchestrationMonitor();

            // create the agent orchestration setup, so they can chat with each other and then provide a final result.
            var kernel = CreateKernelWithChatCompletion(magenticModel, endpoint, apiKey);   
            StandardMagenticManager manager =
                        new(kernel.GetRequiredService<IChatCompletionService>(), new OpenAIPromptExecutionSettings())
                        {
                            InteractiveCallback = async () =>
                            {
                                Console.WriteLine("\n# Press Enter to continue the orchestration...");
                                var userinput = Console.ReadLine();
                                return await Task.FromResult<ChatMessageContent>(new ChatMessageContent()
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
                        builder.AddConsole();
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
          
            await runtime.RunUntilIdleAsync();

            Console.WriteLine("# Orchestration is done...");

            var response = await result.GetValueAsync(TimeSpan.FromSeconds(30));
            //write the orchestration history
            var results = monitor.History;

            foreach(var message in results)
                Console.WriteLine(message.ToString());
           
            return true;
        }
       
        public Kernel CreateKernelWithChatCompletion(string deploymentName, string endpoint, string apiKey)
        {
            var client = new OpenAIClient(new ApiKeyCredential(apiKey),
                new OpenAIClientOptions { Endpoint = new Uri(endpoint) });

            IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
            kernelBuilder.AddOpenAIChatCompletion(deploymentName, client);
            kernelBuilder.Services.AddLogging(
                                 s => s.AddConsole().SetMinimumLevel(LogLevel.Trace));

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
                    builder.Append($"{JsonSerializer.Serialize(response.Content)}");
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
