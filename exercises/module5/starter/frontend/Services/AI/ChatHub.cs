using Microsoft.AspNetCore.SignalR;

namespace GloboTicket.Frontend.Services.AI;

/// <summary>
/// SignalR Hub for chat communication.
/// </summary>
public class ChatHub(ChatAssistant chatAssistant) : Hub
{
    /// <summary>
    /// Method invoked by clients to send a message to the chat assistant.
    /// </summary>
    /// <param name="message">The user message/prompt</param>
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("NewResponse");

        // TODO: call the chat assistant to handle the message
        // TODO: remove this for the starter!
        await chatAssistant.Handle(Context.ConnectionId, message);

        await Clients.All.SendAsync("ResponseDone");
    }
}
