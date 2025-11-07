using Microsoft.AspNetCore.SignalR;

namespace GloboTicket.Frontend.Services.AI;

public class ChatHub(ChatAssistant chatAssistant) : Hub
{
    override public Task OnConnectedAsync()
    {
        Console.WriteLine($"Client connected: {Context.ConnectionId}");
        return base.OnConnectedAsync();
    }

    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("NewResponse");

        await chatAssistant.Handle(Context.ConnectionId, message);

        await Clients.All.SendAsync("ResponseDone");
    }
}
