using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using modulerag;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddUserSecrets<Program>();

IConfiguration config = builder.Build();

var model = config["OpenAI:Model"];
var endpoint = config["OpenAI:EndPoint"];
var token = config["OpenAI:ApiKey"];

var client = new AzureOpenAIClient(new Uri(endpoint), new AzureKeyCredential(token));
var kernelBuilder = Kernel
    .CreateBuilder()
    .AddAzureOpenAIChatCompletion(model, client);

var kernel = kernelBuilder.Build();

await new ChatWithRag().RAG_with_single_prompt(kernel);
