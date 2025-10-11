using System.ComponentModel;

namespace HolAgentFramework;

public class DiscountTool
{
    [Description("Generate a simple GloboTicket discount code for a user.")]
    public static string GetDiscountCode([Description("The name of the user")] string userName = "guest")
    {
        var prefix = userName.ToUpper().Substring(0, Math.Min(4, userName.Length));
        var code = $"{prefix}{Random.Shared.Next(1000, 9999)}";
        return $"Here’s your GloboTicket code: GLOBO-{code}";
    }
}