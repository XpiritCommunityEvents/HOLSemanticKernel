using Microsoft.AspNetCore.SignalR;

namespace GloboTicket.Frontend.Services.AI;

/// <summary>
/// SignalR Hub for chat communication.
/// </summary>
public class ChatHub : Hub
{
    /// <summary>
    /// Method invoked by clients to send a message to the chat assistant.
    /// </summary>
    /// <param name="message">The user message/prompt</param>
    public async Task SendMessage(string message)
    {
        await Clients
            .Client(Context.ConnectionId).SendAsync("NewResponse");

        // TODO: call the chat assistant to handle the message
        await Clients
            .Client(Context.ConnectionId)
            .SendAsync("ReceiveMessagePart", "Hi, I am a dummy assistant. There is no AI here yet ☹️");

        await Clients
            .Client(Context.ConnectionId).SendAsync("ResponseDone");
    }
}
