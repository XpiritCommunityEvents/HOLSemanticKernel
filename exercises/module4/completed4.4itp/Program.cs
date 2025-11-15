using Microsoft.Extensions.Configuration;
using modulerag;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddUserSecrets<Program>();

IConfiguration config = builder.Build();

await new ChatWithAgent().LetAgentFindRideAndHotelWithOrchestrator(config);