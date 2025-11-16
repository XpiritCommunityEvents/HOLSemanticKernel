using Microsoft.SemanticKernel;
using ModelContextProtocol.Client;

namespace GloboTicket.Frontend.Services.AI;

internal static class ServiceCollectionExtensions
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

        // Register the KernelBuilder
        services.AddScoped(sp =>
        {
            var kernelBuilder = Kernel
                .CreateBuilder()
                .UseTelemetry("GloboTicketFrontend", configuration)
                .AddOpenAIChatCompletion(model!, new Uri(endpoint!), key!);
            kernelBuilder.Plugins.AddFromType<Microsoft.SemanticKernel.Plugins.Core.TimePlugin>();

            kernelBuilder.Plugins.AddFromFunctions(
                pluginName: "EventCatalog",
                functions: tools.Select(x => x.AsKernelFunction()));

            return kernelBuilder;
        });

        return services;
    }
}
