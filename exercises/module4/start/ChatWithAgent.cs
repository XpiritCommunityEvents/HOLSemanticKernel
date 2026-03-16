using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;

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
            .AddAzureOpenAIChatCompletion(model, endpoint, token);

        var kernel = kernelBuilder.Build();
        return kernel;
    }
}