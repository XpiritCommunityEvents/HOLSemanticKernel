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

            string azure_client_id = config.GetValue<string>("AZURE_CLIENT_ID") ?? throw new ArgumentException("AZURE_CLIENT_ID not set");
            string azure_tenant_id = config.GetValue<string>("AZURE_TENANT_ID") ?? throw new ArgumentException("AZURE_TENANT_ID not set");
            string azure_client_secret = config.GetValue<string>("AZURE_CLIENT_SECRET") ?? throw new ArgumentException("AZURE_CLIENT_SECRET not set");

            // set environment variables for Azure OpenAI authentication if needed
            Environment.SetEnvironmentVariable("AZURE_CLIENT_ID", azure_client_id);
            Environment.SetEnvironmentVariable("AZURE_TENANT_ID", azure_tenant_id);
            Environment.SetEnvironmentVariable("AZURE_CLIENT_SECRET", azure_client_secret);

            


            await new ChatWithRag().RAG_with_single_prompt(deploymentName, endpoint, apiKey, config);
        }
    }
}
