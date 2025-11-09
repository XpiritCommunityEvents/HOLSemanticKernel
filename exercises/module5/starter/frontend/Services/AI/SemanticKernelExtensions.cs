using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace GloboTicket.Frontend.Services.AI;

internal static class SemanticKernelExtensions
{
    public static IServiceCollection AddSemanticKernelServices(this IServiceCollection services, IConfiguration configuration)
    {
        var key = configuration["OpenAI:ApiKey"];
        var model = configuration["OpenAI:Model"];
        var endpoint = configuration["OpenAI:Endpoint"];

        services.AddScoped(sp =>
        {
            var kernelBuilder = Kernel
                .CreateBuilder()
                .AddAzureAIInferenceChatCompletion(model!, key!, new Uri(endpoint!));

            return kernelBuilder.Build();
        });

        services.AddScoped<ChatAssistant>();

        return services;
    }
}
