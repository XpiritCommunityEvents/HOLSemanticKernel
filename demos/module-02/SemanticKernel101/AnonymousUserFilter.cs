using Microsoft.SemanticKernel;

namespace HOLSemanticKernel;

public class AnonymousUserFilter : IFunctionInvocationFilter
{
    public async Task OnFunctionInvocationAsync(FunctionInvocationContext context, Func<FunctionInvocationContext, Task> next)
    {
        if (context.Function.Name == "get_discount_code")
        {
            if (context.Arguments["userName"]!.ToString() == "guest")
            {
                context.Result = new FunctionResult(context.Function, "No discounts for anonymous users allowed");
                return;
            }
        }
            
        await next(context);

        // you can inspect the results here too to filter for unwanted data
    }
}