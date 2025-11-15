using System.ClientModel;
using System.Text.Json;
using Azure.AI.OpenAI;
using Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.KernelMemory;
using Microsoft.KernelMemory.DocumentStorage.DevTools;
using Microsoft.KernelMemory.FileSystem.DevTools;
using Microsoft.KernelMemory.MemoryStorage.DevTools;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using OpenAI;

namespace modulerag;

internal class ChatWithAgent
{
    public async Task LetAgentFindRide(IConfiguration config)
    {
        Console.WriteLine("******** Create the agent ***********");
        Console.WriteLine("******** Start the agent ***********");
        Console.WriteLine("******** RESPONSE ***********"); 
    }

    private static Kernel CreateKernel(IConfiguration config)
    {
        var model = config["OpenAI:Model"];
        var endpoint = config["OpenAI:EndPoint"];
        var token = config["OpenAI:ApiKey"];

        var kernelBuilder = Kernel
            .CreateBuilder()
            .AddOpenAIChatCompletion(model, new Uri(endpoint), token);

        var kernel = kernelBuilder.Build();
        return kernel;
    }
}