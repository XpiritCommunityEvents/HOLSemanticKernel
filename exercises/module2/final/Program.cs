using System.ClientModel;
using System.Text;
using HolAgentFramework;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using OpenAI;
using OpenAI.Chat;

// Make sure to add ApiKey to your dotnet user secrets...
// dotnet user-secrets set "ApiKey"="<your API key>" -p .\module2.csproj
// PLEASE DO NOT COMMIT YOUR API SECRET TO GIT!

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables()
    .Build();

var token = config["ApiKey"] ?? throw new InvalidOperationException("Missing API Key");
var model = "openai/gpt-4o";
var endpoint = "https://models.github.ai/inference";

var chatClient = new ChatClient(model, new ApiKeyCredential(token), new OpenAIClientOptions()
{
    Endpoint = new Uri(endpoint)
});

var options = new ChatClientAgentRunOptions
{
    ChatOptions = new()
    {
        MaxOutputTokens = 500,
        Temperature = 0.5f,
        TopP = 1.0f,
        FrequencyPenalty = 0.0f,
        PresencePenalty = 0.0f,
    }
};

Console.OutputEncoding = Encoding.UTF8; // the LLM may respond with emojis, so we need UTF8 support
Console.WriteLine("Hi! I am your AI assistant. Talk to me:");

var instructions =
    "You are a digital assistant for GloboTicket, a concert ticketing company. You help customers with their ticket purchasing. Tone: warm and friendly, but to the point. Do not make things up when you don't know the answer. Just tell the user that you don't know the answer based on your knowledge.";

var musicSnob =
    chatClient.CreateAIAgent(
        instructions:
        "You are a music snob. You only like the best bands. When asked, you will only recommend the best bands that are similar to what the user likes.",
        name: "MusicRecommender",
        description: "Recommends music bands based on user preferences.");

var agent = chatClient.CreateAIAgent(instructions,
        name: "GloboTicket Assistant",
        tools: [
            AIFunctionFactory.Create(DiscountTool.GetDiscountCode),
            musicSnob.AsAIFunction()
        ])
    .AsBuilder()
    .Use(DiscountPolicyMiddleware.DisallowAnonymousUsers)
    .Build();

var thread = agent.GetNewThread();

while (true)
{
    Console.WriteLine();

    var prompt = Console.ReadLine();
    
    // synchronous call
    // var response = await agent.RunAsync(prompt!, thread, options);
    // Console.WriteLine(response.Text);
    
    // streaming call
    var responseStream = agent.RunStreamingAsync(prompt!, thread, options);
    await foreach (var chunk in responseStream)
    {
        Console.Write(chunk.Text);
    }
}
