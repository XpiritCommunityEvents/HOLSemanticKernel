# Lab 4.2 - Ingesting documents into a vector database to allow semantic search

In this lab you will learn how to build an advanced Retrieval-Augmented Generation (RAG) system using KernelMemory to chunk and ingest documents into a vector database. Unlike the previous lab where we injected complete documents as context, this approach automatically breaks down large documents into smaller, searchable chunks and stores them in a vector database. This enables semantic search capabilities where the system can find the most relevant pieces of information based on the meaning of the user's question, rather than exact keyword matches. The LLM then uses these retrieved chunks to generate accurate, context-aware responses based on your domain knowledge.

KernelMemory provides a flexible architecture that supports various vector database backends. In this lab, we'll use a FileSystem Vector DB for simplicity, but the same code can be easily configured to work with production-grade solutions like Azure AI Search, Azure Cosmos DB, or Qdrant without changing your application logic.

## Ingestion with KernelMemory

### Steps

#### 1. Open the solution 
In the solution explorer in your codespace by right-clickin the solution file and choose `Open Solution`

#### 3. Add a new function called IngestDocuments
We need to have a new method that will handle the ingestion of documents into the vector database. In the `ChatWithRag.cs` file, add a new method called `IngestDocuments`.

Use the following code

```csharp
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
```

#### 4. Add the GetLocalKernelMemory method
Now we need to add the method that will create the KernelMemory connector to the vector database.

1. Extract and prepare API credentials

```csharp
var openAIApiKey = new ApiKeyCredential(apiKey);
string key = "";
openAIApiKey.Deconstruct(out key);
```

The method begins by taking the provided API key and converting it into the proper credential format. It extracts the raw key string from the ApiKeyCredential object to use in various configuration objects throughout the setup process.

2. Configure text generation service

```csharp
var openAIConfig = new OpenAIConfig
{
    Endpoint = endpoint,
    APIKey = key,
    TextModel = deploymentName,
};
```
Creates an OpenAI configuration object specifically for text generation capabilities. This configuration specifies the endpoint URL, API key, and the deployment name of the language model that will be used for generating responses and processing user queries.

3. Initialize OpenAI client

```csharp
var client = new OpenAIClient(new ApiKeyCredential(apiKey), new OpenAIClientOptions { Endpoint = new Uri(endpoint) });
```

4. Set up embedding generation configuration

```csharp
var openAiEmbedingsConfig = new OpenAIConfig
{
    APIKey = key,
    Endpoint = endpoint,
    EmbeddingModel = "openai/text-embedding-3-small",
};
```

Creates a separate OpenAI configuration specifically for the embedding service. This uses the "text-embedding-3-small" model to convert text documents and queries into vector representations that enable semantic similarity searches in the vector database.

5. Configure file storage backend

```csharp
.WithSimpleFileStorage(new SimpleFileStorageConfig
{
    Directory = "kernel-memory/km-file-storage",
    StorageType = FileSystemTypes.Disk
})
```

Sets up local disk storage for storing original document files. All uploaded documents will be saved in the specified directory on the local filesystem.

6. Configure text database backend

```csharp
.WithSimpleFileStorage(new SimpleFileStorageConfig
{
    Directory = "kernel-memory/km-file-storage",
    StorageType = FileSystemTypes.Disk
})
```

Configures storage for processed and chunked text content. This database manages the text segments that are extracted and processed from the original documents.

7. Configure vector database backend

```csharp
.WithSimpleVectorDb(new SimpleVectorDbConfig
{
    Directory = "kernel-memory/km-vector-db",
    StorageType = FileSystemTypes.Disk
})
```

Sets up the vector database for storing mathematical vector representations (embeddings) of text chunks. This enables semantic similarity searches based on meaning rather than exact keyword matches.

8. Integrate AI services

```csharp
.WithOpenAITextEmbeddingGeneration(openAiEmbedingsConfig)
.WithOpenAITextGeneration(openAIConfig);
```

Connects both the embedding generation service and text generation service to the KernelMemory system. The embedding service automatically converts documents into searchable vectors during ingestion, while the text generation service generates responses based on retrieved context.

9. Build and return the memory instance

```csharp
return kernelMemoryBuilder.Build();
```

Finalizes the configuration and returns a fully functional KernelMemory instance that can ingest documents, perform semantic searches, and integrate with language models for RAG operations. This instance encapsulates all the storage backends and AI services needed for the complete document processing and retrieval pipeline.

<details>
<summary>Complete GetLocalKernelMemory Method Code</summary>

```csharp
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
```

</details>

#### 5. Add a helper method to get the list of files
Add the following method to get the list of files from the directory

```csharp
private IEnumerable<string> GetFileListOfPolicyDocuments(string directory)
{
    return System.IO.Directory.GetFiles(directory, "*.pdf").Select(f => System.IO.Path.GetFileName(f));
}
```

#### 6. Call the IngestDocuments method
Finally, we need to call the IngestDocuments method from the Main method in Program.cs to ingest the documents when we run the application.

```csharp
await new ChatWithRag().IngestDocuments(model, endpoint, token, config);
```

#### 7. Run the application
Now run the application. This will ingest all the documents from the specified directory into the vector database. In the solutition explorer you will see a new folder called `kernel-memory` with the files stored in the vector database. This can also be found in bin/debug depending on your build configuration.

Check the km-file-storage folder to see the ingested documents. Each document will be chunked into smaller pieces and stored in the km-vector-db folder as vectors.

In the km-vector-db folder you will see files that contain the vector representations of the document chunks. These vectors are what enable semantic search capabilities in the RAG system.