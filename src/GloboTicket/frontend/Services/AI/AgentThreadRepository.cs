using System.Collections.Concurrent;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.ChatCompletion;

namespace GloboTicket.Frontend.Services.AI;

/// <summary>
/// A simple in-memory repository for agent threads.
/// </summary>
internal static class AgentThreadRepository
{
    private static ConcurrentDictionary<string, AgentThread> _threads = [];

    /// <summary>
    /// Gets or creates an AgentThread for the given session ID.
    /// </summary>
    /// <param name="sessionId">A unique identifier for the agent session.</param>
    /// <returns>A <see cref="ChatHistory"/> instance associated with the given session ID.</returns>
    public static AgentThread GetOrCreateThread(string sessionId)
    {
        return _threads.GetOrAdd(sessionId, new ChatHistoryAgentThread());
    }
}
