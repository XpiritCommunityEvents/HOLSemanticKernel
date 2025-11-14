using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace modulerag
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddUserSecrets<Program>();

            IConfiguration config = builder.Build();

            var model = config["OpenAI:Model"];
            var endpoint = config["OpenAI:EndPoint"];
            var token = config["OpenAI:ApiKey"];


            var kernelBuilder = Kernel
                .CreateBuilder()
                .AddOpenAIChatCompletion(model, new Uri(endpoint), token);

            var kernel = kernelBuilder.Build();
            Console.WriteLine("Hi! I am your AI assistant. Talk to me:");

            var chatHistory = new ChatHistory();
            chatHistory.AddSystemMessage("You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point. Do not make things up when you don't know the answer. Just tell the user that you don't know the answer based on your knowledge. You also have access to GitHub using the GitHub MCP.");

            var chatCompletionService = kernel.Services.GetService<IChatCompletionService>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("You:");

                var prompt = Console.ReadLine();

                chatHistory.AddUserMessage(prompt!);

                Console.WriteLine();
                Console.WriteLine("GloboTicket assistant:");


                // streaming call
                var responseStream = chatCompletionService!.GetStreamingChatMessageContentsAsync(chatHistory, kernel:kernel);
                await foreach (var response in responseStream)
                {
                    Console.Write(response.Content);
                }
            }
        }
    }
}