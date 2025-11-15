using Elastic.Transport;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulerag;

internal class HotelBookingAgent
{
    public static ChatCompletionAgent CreateChatCompletionAgent(IConfiguration config)
    {
        Kernel kernel = CreateKernel(config);
        ChatCompletionAgent hotelReservationAgent =
        new()
        {
            Name = "HotelReservationAgent",
            Instructions = """
                You are an expert in finding hotel rooms close to music concert locations.
                You provide some options what you have found and ask for approval before you 
                make the booking. You always suggest 3 options with different price ranges.
                You will ask for approval before you make the booking. 
                You are not allowed to make a booking without user confirmation!

                After you succesfully booked the ride you will respond with [** GOAL REACHED **] in your message.            
                """,
            Description = "An agent that finds and books a hotel room close to the concert location",
            Kernel = kernel,
            Arguments = new KernelArguments(new OpenAIPromptExecutionSettings()
            {
                FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
            })
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

