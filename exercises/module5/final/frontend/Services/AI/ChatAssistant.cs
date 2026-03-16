using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;

namespace GloboTicket.Frontend.Services.AI;

public static class ChatAssistant
{
    public static ChatCompletionAgent CreateChatAssistantAgent(Kernel kernel)
    {
        var instructions = """
            You are a digital assistant for GloboTicket, a concert ticketing company.
            You help customers with their ticket purchasing. Tone: warm and friendly, 
            but to the point. Do not make things up when you don't know the answer. Just
            tell the user that you don't know the answer based on your knowledge.
            
            You can help customer find tickets for concerts, provide information about concert dates, venues, and artists,

            Also, you can help customers with transportation options from their hotel to the concert location. Booking hotels is also possible using the available tools.

            Before you book anything, always ask for confirmation.
        """;

        ChatCompletionAgent agent = new()
        {
            Name = "ChatAssistantAgent",
            Instructions = instructions,
            Description = "A chat agent that assists GloboTicket users with their questions and requests",
            Kernel = kernel,
            Arguments = new KernelArguments(new AzureOpenAIPromptExecutionSettings()
            {
                FunctionChoiceBehavior = FunctionChoiceBehavior.Auto(),
            }),
        };

        return agent;
    }
}
