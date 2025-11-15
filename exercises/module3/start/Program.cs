using Microsoft.Extensions.Configuration;
using modulerag;

namespace moduleagent
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

            var model = config["OpenAI:Model"];
            var endpoint = config["OpenAI:EndPoint"];
            var token = config["OpenAI:ApiKey"];


            await new ChatWithAgent().let_agent_find_ride(model, endpoint, token);
        }
    }
}
