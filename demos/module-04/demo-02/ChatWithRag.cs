using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.KernelMemory;
using Microsoft.KernelMemory.DocumentStorage.DevTools;
using Microsoft.KernelMemory.FileSystem.DevTools;
using Microsoft.KernelMemory.MemoryStorage.DevTools;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace modulerag;

public class ChatWithRag
{
        public async Task IngestDocuments(IConfiguration config)
    {
        var directory = "../../../../datasets/venue-policies";

        var memoryConnector = GetLocalKernelMemory(config);

        foreach (var file in GetFileListOfPolicyDocuments(directory))
        {
            var fullfilename = Path.Combine(directory, file);
            var importResult = await memoryConnector.ImportDocumentAsync(filePath: fullfilename, documentId: file);
            Console.WriteLine($"Imported file {file} with result: {importResult}");
        }
    }

    private IEnumerable<string> GetFileListOfPolicyDocuments(string directory)
    {
        return Directory.GetFiles(directory, "*.pdf").Select(f => Path.GetFileName(f));
    }

    private IKernelMemory GetLocalKernelMemory(IConfiguration config)
    {
        // 1. Configure text generation service
        var textGenerationConfig = new OpenAIConfig
        {
            Endpoint = config["OpenAI:EndPoint"]!,
            APIKey = config["OpenAI:ApiKey"]!,
            TextModel = config["OpenAI:Model"]!,
        };

        // 2. Configure embedding generation service
        var openAiEmbeddingsConfig = new OpenAIConfig
        {
            APIKey = config["OpenAI:ApiKey"]!,
            Endpoint = config["OpenAI:EndPoint"]!,
            EmbeddingModel = config["OpenAI:EmbeddingModel"]!,
        };

        // 3-6. Build comprehensive KernelMemory system
        var kernelMemoryBuilder = new KernelMemoryBuilder()
            // 3. Configure file storage backend
            .WithSimpleFileStorage(new SimpleFileStorageConfig
            {
                Directory = "kernel-memory/km-file-storage",
                StorageType = FileSystemTypes.Disk
            })
            // 4. Configure text database backend
            .WithSimpleTextDb(new SimpleTextDbConfig
            {
                Directory = "kernel-memory/km-text-db",
                StorageType = FileSystemTypes.Disk
            })
            // 5. Configure vector database backend
            .WithSimpleVectorDb(new SimpleVectorDbConfig
            {
                Directory = "kernel-memory/km-vector-db",
                StorageType = FileSystemTypes.Disk
            })
            // 6. Integrate AI services
            .WithOpenAITextEmbeddingGeneration(openAiEmbeddingsConfig)
            .WithOpenAITextGeneration(textGenerationConfig);

        // 7. Build and return the memory instance
        return kernelMemoryBuilder.Build();
    }
}
