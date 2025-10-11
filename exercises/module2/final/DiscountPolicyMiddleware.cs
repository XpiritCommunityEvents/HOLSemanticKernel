using System.Text.Json;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;

namespace HolAgentFramework;

public class DiscountPolicyMiddleware
{
    public static async ValueTask<object?> DisallowAnonymousUsers(
        AIAgent agent,
        FunctionInvocationContext context,
        Func<FunctionInvocationContext, CancellationToken, ValueTask<object?>> next,
        CancellationToken cancellationToken)
    {
        if (context.Function.Name == "GetDiscountCode")
        {
            if (!context.Arguments.TryGetValue("userName", out var userName) 
                || ((JsonElement) userName!).GetString() == "guest")
            {
                context.Terminate = true;
                return null;
            }
        }
        
        var result = await next(context, cancellationToken);
        
        // you can inspect the results here too to filter for unwanted data
        return result;
    }
}