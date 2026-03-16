using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddUserSecrets<Program>();

IConfiguration config = builder.Build();

var model = config["OpenAI:Model"]!;
var endpoint = config["OpenAI:EndPoint"]!;
var token = config["OpenAI:ApiKey"]!;

var client = new AzureOpenAIClient(new Uri(endpoint), new AzureKeyCredential(token));
var kernelBuilder = Kernel
    .CreateBuilder()
    .AddAzureOpenAIChatCompletion(model, client);

var kernel = kernelBuilder.Build();

