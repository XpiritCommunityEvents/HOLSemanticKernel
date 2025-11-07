using System.ClientModel;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.KernelMemory;
using Microsoft.KernelMemory.DocumentStorage.DevTools;
using Microsoft.KernelMemory.FileSystem.DevTools;
using Microsoft.KernelMemory.MemoryStorage.DevTools;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using OpenAI;

namespace modulerag
{
    internal class ChatWithRag
    {

        public async Task RAG_with_single_prompt(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {

            var question =
            """
            I booked tickets for a concert tonight in venue AFAS Live.
            I have this small black backpack, not big like for school, more like the mini
            festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
            Is this allowed? 
            """;


            IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
            var client = new OpenAIClient(new ApiKeyCredential(apiKey), new OpenAIClientOptions { Endpoint = new Uri(endpoint) });
            kernelBuilder.AddOpenAIChatCompletion(deploymentName, client);
            Kernel kernel = kernelBuilder.Build();


            var venue = await GetVenueFromQuestion(kernel, question);
            var policyContext = await GetFileContentsFromRepo(kernel, venue);
            var response = await GetResponseOnQuestion(kernel, question, policyContext);

                Console.WriteLine("******** RESPONSE ***********");
            Console.WriteLine(response);
        }

        private async Task<string> GetResponseOnQuestion(Kernel kernel, string question, string policyContext)
        {

            ChatHistory chatHistory = new();
            chatHistory.AddSystemMessage("You are a helpful assistant that answers questions from people that go to a concert and have questions about the venue.");
            chatHistory.AddSystemMessage("Always use the policy information provided in the prompt");
            chatHistory.AddSystemMessage($"### Venue Policy\n {policyContext}");

            chatHistory.AddUserMessage(question);

            var executionSettings = new OpenAIPromptExecutionSettings
            {
                ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
            };

            var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
            var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
            return result.Content;
        }

        private async Task<string> GetVenueFromQuestion(Kernel kernel, string question)
        {
            ChatHistory chatHistory = new();

            chatHistory.AddSystemMessage("You are a helpful asistant that finds the name of a venue from a question.");
            chatHistory.AddSystemMessage("Always get the information from the question. Never search the web or use internal knowledge!");
            chatHistory.AddUserMessage(question);
            var executionSettings = new OpenAIPromptExecutionSettings
            {
                ResponseFormat = typeof(SelectedVenue)
            };
            var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
            var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
            var selectedVenue = JsonSerializer.Deserialize<SelectedVenue>(result.ToString());
            return selectedVenue.venueName;
        }

        private async Task<string> GetFileContentsFromRepo(Kernel kernel, string venueName)
        {
            //Get a list of files from the venue policy repository
            var directory = "/workspaces/HOLSemanticKernel/exercises/module4/datasets/venue-policies";
            var fileList = string.Join("\n", System.IO.Directory.GetFiles(directory, "*.md").Select(f => System.IO.Path.GetFileName(f)));

            var systemprompt = "You are an expert at finding the correct file based on a user question.";
            var fileListPrompt = $"The following is a list of files available:\n{fileList}";
            var fileQuestion = $"Which file contains the venue policy for the venue named '{venueName}'?";

            var chatHistory = new ChatHistory();
            chatHistory.AddSystemMessage(systemprompt);
            chatHistory.AddUserMessage(fileListPrompt);
            chatHistory.AddUserMessage(fileQuestion);

            var executionSettings = new OpenAIPromptExecutionSettings
            {
                ResponseFormat = typeof(SelectedFile)
            };

            var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
            var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);

            var fileResult = JsonSerializer.Deserialize<SelectedFile>(result.ToString());
            var fullfilename = Path.Combine(directory, fileResult.file);
            if (System.IO.File.Exists(fullfilename))
            {
                using (var file = File.OpenText(fullfilename))
                {
                    return file.ReadToEnd();
                }
            }

            return "No Policy information found";

        }


    }


}
