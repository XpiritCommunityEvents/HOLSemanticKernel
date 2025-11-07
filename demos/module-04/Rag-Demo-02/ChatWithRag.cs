using Microsoft.KernelMemory;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.KernelMemory.DocumentStorage.DevTools;
using Microsoft.KernelMemory.FileSystem.DevTools;
using Microsoft.KernelMemory.MemoryStorage.DevTools;
using OpenAI;
using System.ClientModel;
using System;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.ML.OnnxRuntimeGenAI;
using Microsoft.Extensions.Logging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.Json;
using System.IO;

namespace demo_01
{
    internal class ChatWithRag
    {
        private readonly string repoFolder = "C:\\source\\HOLSemanticKernel\\demos\\module-04\\datasets\\venue-policies";

        public async Task RAG_with_single_prompt(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {
            var question =
                """
                I booked tickets for a concert tonight in venue AFAS Live!.
                I have this small black backpack, not big like for school, more like the mini
                festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
                Is this allowed? 
                """;

            //KernelFunction getPolicyFunction = kernel.Plugins.GetFunction("policy", "GetVenuePolicy");
            IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
            //kernelBuilder.Services.AddLogging(
            //                     s => s.AddConsole().SetMinimumLevel(LogLevel.Trace));



            var githubPAT = apiKey;
            var client = new OpenAIClient(new ApiKeyCredential(githubPAT), new OpenAIClientOptions { Endpoint = new Uri(endpoint) });

            kernelBuilder.AddOpenAIChatCompletion(deploymentName, client);

            Kernel kernel = kernelBuilder.Build();

            var venue = await GetVenueFromQuestion(kernel, question);
            var policyContext = await GetFileContentsFromRepo(kernel, venue);
            var response = await GetResponseOnQuestion(kernel, question, policyContext);

     

   
            Console.WriteLine("******** RESPONSE ***********");
            Console.WriteLine(response);

        }

        public async Task IngestDocuments(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {
            var memoryConnector = GetLocalKernelMemory(deploymentName, endpoint, apiKey);

            foreach (var file in GetFileListOfPolicyDocuments(repoFolder))
            {
                var fullfilename = repoFolder + "\\" + file;
                var importResult = await memoryConnector.ImportDocumentAsync(filePath: fullfilename, documentId: file);
                Console.WriteLine($"Imported file {file} with result: {importResult}");
            }

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

        private async Task<string> GetResponseOnQuestion(Kernel kernel, string question, string policyContext)
        {
            ChatHistory chatHistory = new();

            chatHistory.AddSystemMessage("You are a helpful asistant that awnsers questions from people that go to a concert and have questions about the vuenue.");
            chatHistory.AddSystemMessage("Always use the policy information provided by the function GetVenuePolicy, never search the web or use internal knowledge!");
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

       
        private async Task<string> GetFileContentsFromRepo(Kernel kernel, string venueName)
        {
            //Get a list of files from the venue policy repository
  
            var fileList = string.Join("\n", GetFileListOfPolicyDocuments(repoFolder));
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
            var fullfilename = repoFolder + "\\" + fileResult.file;
            if (System.IO.File.Exists(fullfilename))
            {
                using (var file = File.OpenText(fullfilename))
                {
                    return file.ReadToEnd();
                }
            }
            return "No Policy information found";

        }

        private IEnumerable<string> GetFileListOfPolicyDocuments(string directory)
        {
            return System.IO.Directory.GetFiles(directory, "*.pdf").Select(f => System.IO.Path.GetFileName(f));
        }

 
        private class SelectedFile
        {
            public string file { get; set; }
        }
        private class SelectedVenue
        {
            public string venueName { get; set; }
        }


        private IKernelMemory GetLocalKernelMemory(
              string deploymentName,
              string endpoint,
              string apiKey)
        {
            var githubPAT = apiKey;
            var openAIApiKey = new ApiKeyCredential(githubPAT);
            string key = "";
            openAIApiKey.Deconstruct(out key);


            var openAIConfig = new OpenAIConfig
            {
                Endpoint = endpoint,
                APIKey = key,
                TextModel = deploymentName,
            };


            var client = new OpenAIClient(new ApiKeyCredential(githubPAT), new OpenAIClientOptions { Endpoint = new Uri(endpoint) });

            var openAiEmbedingsConfig = new OpenAIConfig
            {
                APIKey = key,
                Endpoint = endpoint,
                EmbeddingModel = "openai/text-embedding-3-small",
            };

            var kernelMemoryBuilder = new KernelMemoryBuilder()
                    .WithSimpleFileStorage(new SimpleFileStorageConfig
                    {
                        Directory = "kernel-memory/km-file-storage",
                        StorageType = FileSystemTypes.Disk
                    })
                    .WithSimpleTextDb(new SimpleTextDbConfig
                    {
                        Directory = "kernel-memory/km-text-db",
                        StorageType = FileSystemTypes.Disk
                    })
                    .WithSimpleVectorDb(new SimpleVectorDbConfig
                    {
                        Directory = "kernel-memory/km-vector-db",
                        StorageType = FileSystemTypes.Disk
                    })
                    .WithOpenAITextEmbeddingGeneration(openAiEmbedingsConfig)
                    .WithOpenAITextGeneration(openAIConfig)
                    //.WithCustomTextPartitioningOptions(
                    //    new TextPartitioningOptions
                    //    {
                    //        MaxTokensPerParagraph = 128,
                    //        MaxTokensPerLine = 128,
                    //        OverlappingTokens = 50
                    //    })
                    ;

            return kernelMemoryBuilder.Build();
        }
    }

    
}
