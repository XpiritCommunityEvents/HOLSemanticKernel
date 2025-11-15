using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;

namespace modulerag;

internal class ConciergeAgent
{
    public static ChatCompletionAgent CreateChatCompletionAgent(IConfiguration config)
    {
        Kernel kernel = CreateKernel(config);
        ChatCompletionAgent hotelReservationAgent =
        new()
        {
            Name = "ConciergeAgent",
            Instructions = """
                You are an expert in using other agents to handle bookings.
                You will recieve information about a concert visit and you need to delegate the booking
                of hotel and rides to other agents. You can ask elaborating questions to clarify the needs.

                - If you need to book an hotel room, you will use the HotelBookingAgent.
                - if you need to book a ride, you will use the RideBookingAgent.
                """,
            Description = "An agent that coordinates the booking of hotel and rides using other agents",
            Kernel = kernel
        };
        return hotelReservationAgent;
    }

    private static Kernel CreateKernel(IConfiguration config)
    {
        var model = config["OpenAI:Model"];
        var endpoint = config["OpenAI:EndPoint"];
        var token = config["OpenAI:ApiKey"];
        var kernelBuilder = Kernel
            .CreateBuilder()
            .AddOpenAIChatCompletion(model, new Uri(endpoint), token);
        var kernel = kernelBuilder.Build();
        return kernel;
    }
}
