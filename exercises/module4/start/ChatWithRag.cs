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

        public async Task IngestDocuments(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {
            var directory = "/workspaces/HOLSemanticKernel/exercises/module4/datasets/venue-policies";
            var memoryConnector = GetLocalKernelMemory(deploymentName, endpoint, apiKey);

            foreach (var file in GetFileListOfPolicyDocuments(directory))
            {
                var fullfilename = Path.Combine(directory, file);
                var importResult = await memoryConnector.ImportDocumentAsync(filePath: fullfilename, documentId: file);
                Console.WriteLine($"Imported file {file} with result: {importResult}");
            }

        }

        public async Task RaG_With_Memory(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {
            var memoryConnector = GetLocalKernelMemory(deploymentName, endpoint, apiKey);

            var question =
                """
        I booked tickets for a concert tonight in venue AFAS Live!.
        I have this small black backpack, not big like for school, more like the mini
        festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
        Is this allowed? 
        """;

            var response = memoryConnector.AskAsync(question);
            Console.WriteLine("******** RESPONSE WITH MEMORY ***********");
            Console.WriteLine(response.Result.Result);

        }


        public async Task AskVenueQuestion(string deploymentName, string endpoint, string apiKey, IConfiguration config)
        {
            var memoryConnector = GetLocalKernelMemory(deploymentName, endpoint, apiKey);
            var question =
                """
                Which venue allows a backpack?
                """;
            var response = memoryConnector.AskAsync(question);
            Console.WriteLine("******** RESPONSE WITH MEMORY ***********");
            Console.WriteLine(response.Result.Result);
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


        private IEnumerable<string> GetFileListOfPolicyDocuments(string directory)
        {
            return System.IO.Directory.GetFiles(directory, "*.pdf").Select(f => System.IO.Path.GetFileName(f));
        }

        private IKernelMemory GetLocalKernelMemory(string deploymentName, string endpoint, string apiKey)
        {
            // 1. Extract and prepare API credentials
            var openAIApiKey = new ApiKeyCredential(apiKey);
            string key = "";
            openAIApiKey.Deconstruct(out key);

            // 2. Configure text generation service
            var openAIConfig = new OpenAIConfig
            {
                Endpoint = endpoint,
                APIKey = key,
                TextModel = deploymentName,
            };

            // 3. Initialize OpenAI client
            var client = new OpenAIClient(new ApiKeyCredential(apiKey), new OpenAIClientOptions { Endpoint = new Uri(endpoint) });

            // 4. Set up embedding generation configuration
            var openAiEmbedingsConfig = new OpenAIConfig
            {
                APIKey = key,
                Endpoint = endpoint,
                EmbeddingModel = "openai/text-embedding-3-small",
            };

            // 5-8. Build comprehensive KernelMemory system
            var kernelMemoryBuilder = new KernelMemoryBuilder()
                // 5. Configure file storage backend
                .WithSimpleFileStorage(new SimpleFileStorageConfig
                {
                    Directory = "kernel-memory/km-file-storage",
                    StorageType = FileSystemTypes.Disk
                })
                // 6. Configure text database backend
                .WithSimpleTextDb(new SimpleTextDbConfig
                {
                    Directory = "kernel-memory/km-text-db",
                    StorageType = FileSystemTypes.Disk
                })
                // 7. Configure vector database backend
                .WithSimpleVectorDb(new SimpleVectorDbConfig
                {
                    Directory = "kernel-memory/km-vector-db",
                    StorageType = FileSystemTypes.Disk
                })
                // 8. Integrate AI services
                .WithOpenAITextEmbeddingGeneration(openAiEmbedingsConfig)
                .WithOpenAITextGeneration(openAIConfig);

            // 9. Build and return the memory instance
            return kernelMemoryBuilder.Build();

        }


    }
}