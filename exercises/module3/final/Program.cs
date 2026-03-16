using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.InMemory;
using modulerag;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddUserSecrets<Program>();

IConfiguration config = builder.Build();

var model = config["OpenAI:Model"]!;
var endpoint = config["OpenAI:EndPoint"]!;
var token = config["OpenAI:ApiKey"]!;

var client = new AzureOpenAIClient(new Uri(endpoint), new AzureKeyCredential(token));
var kernelBuilder = Kernel
    .CreateBuilder()
    .AddAzureOpenAIChatCompletion(model, client);

var kernel = kernelBuilder.Build();

VectorStore vectorStore = new InMemoryVectorStore();
var collection = vectorStore.GetCollection<ulong, PolicyFilePart>("venue-policies");
await collection.EnsureCollectionExistsAsync();

var embeddingGenerator = client.GetEmbeddingClient("text-embedding-3-small").AsIEmbeddingGenerator(defaultModelDimensions: 1536);

var chat = new ChatWithRag();

await chat.RAG_with_single_prompt(kernel);

await chat.IngestDocuments(collection, embeddingGenerator);
await chat.RAG_with_memory(kernel, collection, embeddingGenerator);
await chat.AskVenueQuestion(kernel, collection, embeddingGenerator);
