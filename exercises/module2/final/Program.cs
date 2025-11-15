using HOLSemanticKernel;
using Microsoft.SemanticKernel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.PromptTemplates.Handlebars;
using ModelContextProtocol.Client;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.Extensions.Logging;

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

// var mcpClient = await McpClient.CreateAsync(new HttpClientTransport(
//     new HttpClientTransportOptions
//     {
//         Name = "GitHub",
//         Endpoint = new Uri("https://api.githubcopilot.com/mcp/"),
//         AdditionalHeaders = new Dictionary<string, string>
//         {
//             ["Authorization"] = $"Bearer {config["GitHubToken"]}"
//         }
//     }));
kernelBuilder.Services.AddLogging(
    s => s.AddConsole().SetMinimumLevel(LogLevel.Debug));

var kernel = kernelBuilder.Build();

// var tools = await mcpClient.ListToolsAsync();
// kernel.ImportPluginFromFunctions("GitHub", tools.Select(x => x.AsKernelFunction()));
kernel.ImportPluginFromType<Microsoft.SemanticKernel.Plugins.Core.TimePlugin>();
kernel.ImportPluginFromType<DiscountPlugin>();

var promptTemplate = File.ReadAllText(Path.Join(Directory.GetCurrentDirectory(), "music_recommender.yaml"));
var musicRecommender = kernel.CreateFunctionFromPromptYaml(
    promptTemplate,
    new HandlebarsPromptTemplateFactory()
    {
        AllowDangerouslySetContent = true
    });
kernel.ImportPluginFromFunctions("music_recommender", [musicRecommender]);

var executionSettings = new OpenAIPromptExecutionSettings
{
    MaxTokens = 500,
    Temperature = 0.5,
    TopP = 1.0,
    FrequencyPenalty = 0.0,
    PresencePenalty = 0.0,
    FunctionChoiceBehavior = FunctionChoiceBehavior.Auto(),
//    ResponseFormat = typeof(ArtistSuggestions),
};

Console.WriteLine("Hi! I am your AI assistant. Talk to me:");

var chatHistory = new ChatHistory();
chatHistory.AddSystemMessage("You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point. Do not make things up when you don't know the answer. Just tell the user that you don't know the answer based on your knowledge. You also have access to GitHub using the GitHub MCP.");

var chatCompletionService = kernel.Services.GetService<IChatCompletionService>();

// var multiModalChat = new ChatHistory("Your job is to identify musical instruments from images.");
// multiModalChat.AddUserMessage(
// [
//     new Microsoft.SemanticKernel.TextContent("Can you identify this instrument? Be specific about brand and type."),
//     new Microsoft.SemanticKernel.ImageContent(File.ReadAllBytes("guitar.jpg"), "image/jpg")
// ]);

// var multiModalResponse = await chatCompletionService!.GetChatMessageContentsAsync(multiModalChat, executionSettings, kernel);
// Console.WriteLine(multiModalResponse.Last().Content);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("You:");

    var prompt = Console.ReadLine();

    // direct plugin call
    // if (prompt!.Contains("discount"))
    // {
    //     var arguments = new KernelArguments { ["userName"] = "guest" };
    //     var discount = await kernel.InvokeAsync<string>(
    //         nameof(DiscountPlugin),
    //         "get_discount_code",
    //         arguments);
    //     
    //     Console.WriteLine(discount);
    //     continue;
    // }

    chatHistory.AddUserMessage(prompt!);

    Console.WriteLine();
    Console.WriteLine("GloboTicket assistant:");

    // synchronous call
    var response = await chatCompletionService!.GetChatMessageContentsAsync(chatHistory, executionSettings, kernel);
    Console.WriteLine(response.Last().Content);

    // streaming call
    // var responseStream = chatCompletionService!.GetStreamingChatMessageContentsAsync(chatHistory, executionSettings, kernel);
    // await foreach (var response in responseStream)
    // {
    //     Console.Write(response.Content);
    // }
}
