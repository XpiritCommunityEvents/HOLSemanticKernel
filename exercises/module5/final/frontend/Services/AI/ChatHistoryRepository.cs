using System;
using System.Collections.Concurrent;
using Microsoft.SemanticKernel.ChatCompletion;

namespace GloboTicket.Frontend.Services.AI;

internal static class ChatHistoryRepository
{
    private static ConcurrentDictionary<string, ChatHistory> _histories = [];

    public static ChatHistory GetOrCreateHistory(string sessionId)
    {
        return _histories.GetOrAdd(sessionId, InitializeChat());
    }

    private static ChatHistory InitializeChat()
    {
        var chatHistory = new ChatHistory();
        chatHistory.AddSystemMessage("""
            You are a digital assistant for GloboTicket, a concert ticketing company.
            You help customers with their ticket purchasing. Tone: warm and friendly, 
            but to the point. Do not make things up when you don't know the answer. Just
            tell the user that you don't know the answer based on your knowledge.
        """);
        return chatHistory;
    }
}
