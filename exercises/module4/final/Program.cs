using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.Qdrant;
using module4.Services;
using Qdrant.Client;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var kernelBuilder = builder.Services.AddKernel()
            .AddAzureOpenAIChatCompletion(
                deploymentName: builder.Configuration["LanguageModel:CompletionModel"]!,
                endpoint: builder.Configuration["LanguageModel:Endpoint"]!,
                apiKey: builder.Configuration["LanguageModel:ApiKey"]!
            )
            .AddAzureOpenAIEmbeddingGenerator(
                deploymentName: builder.Configuration["LanguageModel:EmbeddingModel"]!,
                endpoint: builder.Configuration["LanguageModel:EmbeddingEndpoint"]!,
                apiKey: builder.Configuration["LanguageModel:EmbeddingApiKey"]!
            );

        builder.Services.AddQdrantVectorStore("localhost", 6334, false);
        builder.Services.AddSingleton<ContentIndexer>();
        builder.Services.AddSingleton<QuestionAnsweringTool>();

        var app = builder.Build();

        app.MapGet("/answer", async ([FromServices] QuestionAnsweringTool tool, [FromQuery] string question) =>
        {
            var result = await tool.AnswerAsync(question);
            return result.Response;
        });

        var scope = app.Services.CreateScope();
        var indexer = scope.ServiceProvider.GetRequiredService<ContentIndexer>();

        await indexer.ProcessContentAsync();

        await app.RunAsync();
    }
}