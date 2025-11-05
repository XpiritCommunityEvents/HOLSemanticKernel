# Lab 2.2 - Plugins & Function Calling

In this lab, we will implement a simple plugin that generates a random discount code when the user asks for it. First, we are going to invoke it manually, and then we will let the LLM automatically invoke it.

The plugin we are going to create here is a simple hard coded random code generator. We will make a more sophisticated plugin that accesses the GloboTicket database later today. 

## Implement a GloboTicket discount plugin

### Steps

1. In your project, create a new file named `DiscountPlugin.cs`. Implement the plugin as follows:

    ```csharp
    namespace HOLSemanticKernel;

    public class DiscountPlugin()
    {
        public string GetDiscountCode(string userName = "guest")
        {
            var prefix = userName.ToUpper().Substring(0, Math.Min(4, userName.Length));
            var code = $"{prefix}{Random.Shared.Next(1000, 9999)}";
            return $"Here’s your GloboTicket code: GLOBO-{code}";
        }
    }
    ```

    As you can see it is just a plain C# class with a simple method that returns a `string` value.

2. To make the plugin usable by the LLM, we have to mark it with some metadata. Add the following attribute to the `GetDiscountCode` method:

    ```csharp
    [KernelFunction("get_discount_code")]
    public string GetDiscountCode(string userName = "guest")
    {
        //... rest of the code
    ```

3. Bring in the necessary namespace for this attributes at the top of the file:

    ```csharp
    using Microsoft.SemanticKernel;
    ```

We have now marked the `GetDiscountCode` method as a `KernelFunction` to be used by Semantic Kernel. Notice the label `"get_discount_code"` we gave it. This will be the name of the method that the LLM will refer to. Let's call it in our application:

4. Register the plugin with the Semantic Kernel by adding the following line _just before_ the call to `kernelBuilder.Build()`:

    ```csharp
    kernelBuilder.Plugins.AddFromType<DiscountPlugin>(); // <-- add this

    var kernel = kernelBuilder.Build();
    ```

5. To call the plugin, add the following code to the chat loop in your application, just after reading the prompt from the console:

    ```csharp
    var prompt = Console.ReadLine();

    if (prompt!.Contains("discount"))
    {
        var arguments = new KernelArguments { ["userName"] = "guest" };
        var discount = await kernel.InvokeAsync<string>(
            nameof(DiscountPlugin),
            "get_discount_code",
            arguments);
        
        Console.WriteLine(discount);
        continue;
    }
    ```

    Run the application and ask for a discount. As long as you use the word "discount" in your prompt, your program will invoke the `get_discount_code` function on your `DiscountPlugin` directly.

## Make the plugin discoverable for the LLM

We now know how to register a plugin with the Semantic Kernel and how to invoke it manually. But the most powerful way to use plugins is to let the LLM invoke the kernel function itself automatically. Let's make this possible.

We need to add a bit more information to the plugin to make it discoverable for the LLM.

### Steps

1. Remove or comment out the block of code you just added that invokes the kernel function explicitly. 

2. Add the following attributes to the `GetDiscountCode` kernel function in your `DiscountPlugin`:

    ```csharp
    [KernelFunction("get_discount_code")] // already there
    [Description("Generate a simple GloboTicket discount code for a user.")]
    public string GetDiscountCode([Description("The name of the user")] string userName = "guest")
    ```

    You need to add a `using System.ComponentModel;` statement to the top of the file to use the `Description` attribute. 

    This gives context and meaning to the plugin's `GetDiscountCode` method, which makes it possible for the LLM to know it can use this method for generating a discount code.

3. Instruct the Semantic Kernel to automatically invoke functions by adding a property to the prompt execution settings:

    ```csharp
    var executionSettings = new AzureOpenAIPromptExecutionSettings
    {
        MaxTokens = 500,
        Temperature = 0.5,
        TopP = 1.0,
        FrequencyPenalty = 0.0,
        PresencePenalty = 0.0,
        FunctionChoiceBehavior = FunctionChoiceBehavior.Auto() // <-- add this
    };
    ```

4. Run the application again and ask for a discount. Does it invoke the `GetDiscount` method? Place a breakpoint inside that method to verify that it does.

5. Now tell the LLM your name and ask for a discount again. What happens to the `userName` parameter for the `GetDiscountCode`? Do you notice that the LLM automatically knows what to pass into the kernel function?

## Prevent function calls using a Filter

Let's say we don't want to give out any discounts to anonymous users. We don't have any user management built into this application, but let's only give discounts to users who tell the LLM their name.

We can use a _Function Invocation Filter_ to intercept the function call and inspect input and output of kernel functions. This way we can prevent unwanted information from being added to the conversation. A Function Invocation Filter is plugged into the call chain of the Semantic Kernel, just like middleware in an ASP.NET request pipeline. This allows you to perform any check or action _before_ and _after_ the function is invoked.

### Steps

1. Add a new class named `AnonymousUserFilter` to the project.

2. Let the class implement the `IFunctionInvocationFilter` interface. This requires the following method to be implemented:

    ```csharp
    public class AnonymousUserFilter : IFunctionInvocationFilter
    {
        public Task OnFunctionInvocationAsync(FunctionInvocationContext context, Func<FunctionInvocationContext, Task> next)
        {
            // implementation goes here
        }
    }
    ```

    The `FunctionInvocationContext` parameter contains information about the function that is about to be called. The `Func<FunctionInvocationContext, Task> next` delegate lets you invoke the next step in the function invocation pipeline.
    
3. Let's add the following implementation:

    ```csharp
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
    ```

    A Function Invocation Filter is executed for any function call, so if you want to filter for a specific function, you need to inspect the `context.Function.Name` like in the sample above. When the `userName` is `"guest"`, we short cut the call by returning a string telling that discounts for anonymous users are not allowed.

4. Register the filter with the Semantic Kernel just like we did with the plugin. In your `Program.cs`, add the following line just before the call to `kernelBuilder.Build()`:

    ```csharp
    kernelBuilder.Services.AddTransient<IFunctionInvocationFilter, AnonymousUserFilter>();

    var kernel = kernelBuilder.Build(); // <-- existing code

    ```

5. Run the program again in debug mode and set a breakpoint in the `AnonymousUserFilter` code.

6. Ask the system for a discount without telling it your name. Does your filter get invoked with `"guest"` for the `userName` parameter? How does the system respond?

7. Now tell the LLM your name and ask for a discount again. Now you should see that the plugin is invoked and a discount is generated.

## Implement a prompt function

Besides a code based function, you can also implement a prompt based function. These are functions that are also executed by an LLM based on a specific prompt. Let's implement one of those too.

To show what is possible, we're going to create a YAML based prompt.

- Add a file to your project named `music_recommender.yaml`
- Paste the following content into the file

  ```yaml
  name: music_recommender
  description: You are a music snob. You only like the best bands. When asked, you will only recommend the best bands that are similar to what the user likes.
  template: |
    Provide a list of 10 artists or bands that are similar to the user's music preference: {{ musicPreference }}.
    Output your recommendations as a list of bullet points.
  
    Recommendations:
  template_format: handlebars
  input_variables:
    - name: musicPreference
      description: The music preference of the user.
      is_required: true
  execution_settings:
    default:
      top_p: 0.98
      temperature: 0.7
      presence_penalty: 0.0
      frequency_penalty: 0.0
      max_tokens: 1200
  ```
- Examine this file. This YAML format lets you define a reusable prompt which is templated using the [Handlebars](https://handlebarsjs.com/) syntax. You can reference input variables in the template in your prompt template, like we did with `{{ musicPreference }}`. As you can see, we also set some execution settings specific for this prompt. All this makes it an encapsulated and reusable AI based function.

- Make sure the file is included in your application's output as content. Add the following section to the `.csproj` file:

  ```xml
  <ItemGroup>
    <Content Include="music_recommender.yaml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  ```

- Now we need 2 additional packages in order to read and use this prompt.

  ```pwsh
  dotnet add package Microsoft.SemanticKernel.PromptTemplates.Handlebars
  dotnet add package Microsoft.SemanticKernel.Yaml
  ```

- Add the following `using` statement to the top of your `Program.cs`:

  ```csharp
  using Microsoft.SemanticKernel.PromptTemplates.Handlebars;
  ```

- Now add the prompt based function to the kernel with the following lines, just below the `var kernel = KernelBuilder.Build();`:

  ```csharp
  var kernel = kernelBuilder.Build();

  var promptTemplate = File.ReadAllText(Path.Join(Directory.GetCurrentDirectory(), "music_recommender.yaml"));
  
  var musicRecommender = kernel.CreateFunctionFromPromptYaml(
    promptTemplate,
    new HandlebarsPromptTemplateFactory()
    {
        AllowDangerouslySetContent = true
    });
  
  kernel.Plugins.AddFromFunctions("music_recommender", [musicRecommender]);
  ```

The `CreateFunctionFromPromptYaml` extension method comes from the package we just added. Note that we're specifying the `HandlebarsPromptTemplateFactory` to indicate that the prompt has a Handlebars based syntax. `AllowDangerouslySetContent = true` is not recommended for production scenarios but it lets our GloboTicket assistant pass the user's music preference without having to do a value conversion to a simple `string`.

- Run the application again and tell the assistant your favorite artist or music style. Ask for recommendations. The `music_recommender` should be invoked and return a bulleted list of 10 suggestions.

