using Microsoft.AspNetCore.SignalR;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace GloboTicket.Frontend.Services.AI;

public class ChatAssistant(Kernel kernel, IHubContext<ChatHub> hubContext)
{
    public async Task Handle(string sessionId, string prompt)
    {
        var chatHistory = ChatHistoryRepository.GetOrCreateHistory(sessionId);
        chatHistory.AddUserMessage(prompt);

        var chatCompletionService = kernel.Services.GetService<IChatCompletionService>();

        var responseStream = chatCompletionService!.GetStreamingChatMessageContentsAsync(chatHistory, kernel: kernel);
        await foreach (var response in responseStream)
        {
            if (response.Content != null)
            {
                await hubContext.Clients
                    .Client(sessionId.ToString())
                    .SendAsync("ReceiveMessagePart", response.Content);
            }
        }
    }
}
