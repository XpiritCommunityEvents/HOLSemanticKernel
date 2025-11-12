using System.Collections.Concurrent;
using Microsoft.SemanticKernel.ChatCompletion;

namespace GloboTicket.Frontend.Services.AI;

/// <summary>
/// A simple in-memory repository for chat histories.
/// </summary>
internal static class ChatHistoryRepository
{
    private static ConcurrentDictionary<string, ChatHistory> _histories = new ConcurrentDictionary<string, ChatHistory>();

    /// <summary>
    /// Gets or creates a ChatHistory for the given session ID.
    /// </summary>
    /// <param name="sessionId">A unique identifier for the chat session.</param>
    /// <returns>A <see cref="ChatHistory"/> instance associated with the given session ID.</returns>
    public static ChatHistory GetOrCreateHistory(string sessionId)
    {
        return _histories.GetOrAdd(sessionId, InitializeChat());
    }

    /// <summary>
    /// Initializes a new chat history with a system message.
    /// </summary>
    /// <returns>A new <see cref="ChatHistory"/> instance.</returns>
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
