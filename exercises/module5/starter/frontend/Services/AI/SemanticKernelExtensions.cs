using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using ModelContextProtocol.Client;

namespace GloboTicket.Frontend.Services.AI;

internal static class SemanticKernelExtensions
{
    public static async Task<IServiceCollection> AddSemanticKernelServices(this IServiceCollection services, IConfiguration configuration)
    {
        var key = configuration["OpenAI:ApiKey"];
        var model = configuration["OpenAI:Model"];
        var endpoint = configuration["OpenAI:Endpoint"];

        var mcpClient = await McpClient.CreateAsync(new HttpClientTransport(
                    new HttpClientTransportOptions
                    {
                        Name = "EventCatalog",
                        Endpoint = new Uri($"{configuration["ApiConfigs:EventCatalog:Uri"]}/mcp/")
                    }));
        var tools = await mcpClient.ListToolsAsync();

        services.AddScoped(sp =>
        {
            var kernelBuilder = Kernel
                .CreateBuilder()
                .AddAzureAIInferenceChatCompletion(model!, key!, new Uri(endpoint!));

            kernelBuilder.Plugins.AddFromFunctions(
                pluginName: "EventCatalog",
                functions: tools.Select(x => x.AsKernelFunction()));

            return kernelBuilder.Build();
        });

        services.AddSingleton(new AzureOpenAIPromptExecutionSettings
        {
            MaxTokens = 500,
            Temperature = 0.5,
            TopP = 1.0,
            FrequencyPenalty = 0.0,
            PresencePenalty = 0.0,
            FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
        });

        services.AddScoped<ChatAssistant>();
        return services;
    }
}
