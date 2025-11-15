using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using modulerag;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddUserSecrets<Program>();

IConfiguration config = builder.Build();

//await new ChatWithAgent().LetAgentFindRide(config);
await new ChatWithAgent().LetAgentFindRideAndHotel(config);