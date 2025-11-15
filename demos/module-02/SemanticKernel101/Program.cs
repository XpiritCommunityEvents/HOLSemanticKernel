using Microsoft.SemanticKernel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

// Make sure to add ApiKey to your dotnet user secrets...
// dotnet user-secrets set "ApiKey"="<your API key>" -p .\module2.csproj
// PLEASE DO NOT COMMIT YOUR API SECRET TO GIT!

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables()
    .Build();

var token = config["OpenAI:ApiKey"] ?? throw new InvalidOperationException("Missing API Key");
var model = "openai/gpt-4o";
var endpoint = "https://models.github.ai/orgs/XpiritComunnityEvents/inference";

var kernelBuilder = Kernel
    .CreateBuilder()
    .AddOpenAIChatCompletion(model, new Uri(endpoint), token);

// kernelBuilder.Services.AddTransient<IFunctionInvocationFilter, AnonymousUserFilter>();

var kernel = kernelBuilder.Build();

kernel.ImportPluginFromType<Microsoft.SemanticKernel.Plugins.Core.TimePlugin>();
//kernel.ImportPluginFromType<DiscountPlugin>();

var executionSettings = new OpenAIPromptExecutionSettings
{
    MaxTokens = 500,
    Temperature = 0.5,
    TopP = 1.0,
    FrequencyPenalty = 0.0,
    PresencePenalty = 0.0,
//    ResponseFormat = typeof(SemanticKernel101.Summary),
//    FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
};

Console.WriteLine("Hi! I am your AI assistant. Talk to me:");

var chatHistory = new ChatHistory();
chatHistory.AddSystemMessage("""
    You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing.
    Tone: warm and friendly, but to the point. Do not make things up when you don't know the answer. Just tell the user that 
    you don't know the answer based on your knowledge.
""");

var chatCompletionService = kernel.Services.GetRequiredService<IChatCompletionService>();

while (true)
{
    Console.WriteLine();

    var prompt = Console.ReadLine();

    chatHistory.AddUserMessage(prompt!);

    // // synchronous call
    var response = await chatCompletionService!.GetChatMessageContentsAsync(chatHistory, executionSettings, kernel);
    Console.WriteLine(response.Last().Content);

    // streaming call
    // var responseStream = chatCompletionService!.GetStreamingChatMessageContentsAsync(chatHistory, executionSettings, kernel);
    // await foreach (var response in responseStream)
    // {
    //     Console.Write(response.Content);
    // }
}
