using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using OpenAI;
using System.ClientModel;

namespace demo_01
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddUserSecrets<Program>();

            IConfiguration config = builder.Build();

            string deploymentName = config.GetSection("OpenAI").GetValue<string>("Model") ?? throw new ArgumentException("OpenAI Model not set");
            string endpoint = config.GetSection("OpenAI").GetValue<string>("EndPoint") ?? throw new ArgumentException("OpenAI EndPoint not set");
            string apiKey = config.GetSection("OpenAI").GetValue<string>("ApiKey") ?? throw new ArgumentException("OpenAIKey not set");
            


            await new ChatWithRag().IngestDocuments(deploymentName, endpoint, apiKey, config);
            await new ChatWithRag().RaG_With_Memory(deploymentName, endpoint, apiKey, config);
            await new ChatWithRag().AskVenueQuestion(deploymentName, endpoint, apiKey, config);

        }
    }
}
