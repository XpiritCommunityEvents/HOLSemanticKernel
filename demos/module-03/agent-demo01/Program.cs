using Microsoft.Extensions.Configuration;

namespace agent_demo01
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
            //string magenticModel = config.GetValue<string>("magenticModel")?? throw new ArgumentException("magentic model not set");
            var info = new TicketInformation() { 
                Artist = "Bruce springsteen",
                Location = "AFAS Live, netherlands",
                EventName = "Bruce Springsteen Tours & Concerts",
                EventDate = new DateTime(2026, 11, 15)
            };
             await new PlanMyVisit().PlanVisit(info, deploymentName, endpoint, apiKey, deploymentName/*"openai/o4-mini"*/);

        }
    }
}
