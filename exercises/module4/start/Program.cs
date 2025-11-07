using Microsoft.Extensions.Configuration;

namespace modulerag
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


        //    await new ChatWithRag().RAG_with_single_prompt(model, endpoint, token, config);

            //await new ChatWithRag().IngestDocuments(model, endpoint, token, config);

            // await new ChatWithRag().RaG_With_Memory(model, endpoint, token, config);
            await new ChatWithRag().AskVenueQuestion(model, endpoint, token, config);
        }
    }
}
