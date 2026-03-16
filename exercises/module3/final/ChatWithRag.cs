using MarkdownStructureChunker.Core;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using System.Text.Json;

namespace modulerag;

internal class ChatWithRag
{
    public async Task RAG_with_single_prompt(Kernel kernel)
    {
        var question =
        """
        I booked tickets for a concert tonight in venue AFAS Live.
        I have this small black backpack, not big like for school, more like the mini
        festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
        Is this allowed? 
        """;

        var venue = await GetVenueFromQuestion(kernel, question);
        var policyContext = await GetFileContentsFromRepo(kernel, venue);
        var response = await GetResponseOnQuestion(kernel, question, policyContext);

        Console.WriteLine("******** RESPONSE ***********");
        Console.WriteLine(response);
    }

    public async Task RAG_with_memory(Kernel kernel, VectorStoreCollection<ulong, PolicyFilePart> collection, IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator)
    {
        var question =
            """
            I booked tickets for a concert tonight in venue AFAS Live!.
            I have this small black backpack, not big like for school, more like the mini
            festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
            Is this allowed? 
            """;

        var questionEmbedding = await embeddingGenerator.GenerateAsync(question);

        var searchResult = await collection.SearchAsync(questionEmbedding.Vector, top: 1).ToListAsync();

        var response = await GetResponseOnQuestion(kernel, question, searchResult.FirstOrDefault()?.Record?.Chunk ?? "No information found");

        Console.WriteLine("******** RESPONSE WITH MEMORY ***********");
        Console.WriteLine(response);
    }

    public async Task AskVenueQuestion(Kernel kernel, VectorStoreCollection<ulong, PolicyFilePart> collection, IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator)
    {
        var question =
            """
            Which venue allows a backpack?
            """;

        var questionEmbedding = await embeddingGenerator.GenerateAsync(question);
        var searchResult = await collection.SearchAsync(questionEmbedding.Vector, top: 50).ToListAsync();

        var response = await GetResponseOnQuestion(kernel, question, string.Join("\n\n", searchResult.Select(r => r.Record.Chunk)));

        Console.WriteLine("******** RESPONSE WITH MEMORY ***********");
        Console.WriteLine(response);
    }

    public async Task IngestDocuments(VectorStoreCollection<ulong, PolicyFilePart> collection, IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator)
    {
        var chunker = StructureChunker.CreateStructureFirst();

        List<PolicyFilePart> files = [];

        ulong key = 0;
        var directory = "../../../../datasets/venue-policies";
        foreach (var file in GetFileListOfPolicyDocuments(directory))
        {
            var fullfilename = Path.Combine(directory, file);

            // mimic a persistent storage using json serializations
            // you would normally use a database for this
            var jsonCacheFileName = Path.ChangeExtension(fullfilename, ".json");
            if (File.Exists(jsonCacheFileName))
            {
                var cachedChunks = JsonSerializer.Deserialize<PolicyFilePart[]>(File.ReadAllBytes(jsonCacheFileName));
                files.AddRange(cachedChunks!);
                Console.WriteLine($"Loaded cached venue policy file from {jsonCacheFileName}");
            }
            else
            {
                List<PolicyFilePart> venueChunks = [];

                // Chunk the MD file by its structure (headings, numbered lists, etc)
                string fileContent = File.ReadAllText(fullfilename);
                var chunks = await chunker.ChunkAsync(fileContent);

                foreach (var chunk in chunks)
                {
                    var filePart = new PolicyFilePart
                    {
                        Key = key++,
                        FileName = file,
                        Chunk = $"# Venue: {file}\n{chunk.Content}",
                    };

                    var embedding = await embeddingGenerator.GenerateAsync(filePart.Chunk);
                    filePart.EmbeddingVector = embedding.Vector;

                    venueChunks.Add(filePart);
                }

                using var jsonFile = File.OpenWrite(jsonCacheFileName);
                await JsonSerializer.SerializeAsync(jsonFile, venueChunks);

                Console.WriteLine($"Imported file {file} with {chunks.Count()} chunks");

                files.AddRange(venueChunks);
            }
        }

        await collection.UpsertAsync(files);
    }

    private async Task<string> GetResponseOnQuestion(Kernel kernel, string question, string policyContext)
    {
        ChatHistory chatHistory = new();
        chatHistory.AddSystemMessage("You are a helpful assistant that answers questions from people that go to a concert and have questions about the venue.");
        chatHistory.AddSystemMessage("Always use the policy information provided in the prompt");
        chatHistory.AddSystemMessage($"### Venue Policy\n {policyContext}");

        chatHistory.AddUserMessage(question);

        var executionSettings = new AzureOpenAIPromptExecutionSettings
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
        var executionSettings = new AzureOpenAIPromptExecutionSettings
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
        var directory = "../../../../datasets/venue-policies";
        var fileList = string.Join("\n", Directory.GetFiles(directory, "*.md").Select(f => Path.GetFileName(f)));

        var systemprompt = "You are an expert at finding the correct file based on a user question.";
        var fileListPrompt = $"The following is a list of files available:\n{fileList}";
        var fileQuestion = $"Which file contains the venue policy for the venue named '{venueName}'?";

        var chatHistory = new ChatHistory();
        chatHistory.AddSystemMessage(systemprompt);
        chatHistory.AddUserMessage(fileListPrompt);
        chatHistory.AddUserMessage(fileQuestion);

        var executionSettings = new AzureOpenAIPromptExecutionSettings
        {
            ResponseFormat = typeof(SelectedFile)
        };

        var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);

        var fileResult = JsonSerializer.Deserialize<SelectedFile>(result.ToString());
        var fullfilename = Path.Combine(directory, fileResult.file);
        if (File.Exists(fullfilename))
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
        return Directory.GetFiles(directory, "*.md").Select(f => Path.GetFileName(f));
    }
}