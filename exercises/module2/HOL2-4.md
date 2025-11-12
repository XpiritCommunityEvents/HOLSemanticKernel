# Lab 2.4 - Structured responses

In some cases, you want to process the response of your LLM programmatically instead of showing it to the user as plain text. You can force the LLM to return a structured response by specifying a `ResponseFormat` in the prompt execution settings. Let's try this out.

## Returning structured artist suggestions

You are going to let the LLM respond with artist suggestions in JSON format.

### Steps

- First, we'll define a class structure for our desired response format. Add a class to the project called `ArtistSuggestions`. Implement the following simple structure:

    ```csharp
    namespace HOLSemanticKernel;

    public class ArtistSuggestions
    {
        public Artist[] Artists { get; set; }
    }

    public class Artist
    {
        public string Name { get; set; }
        public string SummaryText { get; set; }
    }
    ```

    This is a simple root `ArtistSuggestions` object with a list of `Artist` elements.

- Instruct the LLM to use this class as the response format by adding the following property to the prompt execution settings:

    ```csharp
    var executionSettings = new OpenAIPromptExecutionSettings
    {
        MaxTokens = 500,
        Temperature = 0.5,
        TopP = 1.0,
        FrequencyPenalty = 0.0,
        PresencePenalty = 0.0,
        FunctionChoiceBehavior = FunctionChoiceBehavior.Auto(),
        ResponseFormat = typeof(ArtistSuggestions), // <<--- add this line
    };
    ```
- Run the application again and tell the LLM your favourite artist. After some time, it should come up with a JSON structure that matches the `ArtistSuggestions` definition.

The JSON response can be deserialized, for example with `System.Text.Json` so you can process it in a typed manner.

Response formats are very useful for very specific prompts that you want to process automatically. They are less suitable for user chats that require more human readable text. Semantic Kernel helps you mix and match these scenarios.

This concludes lab 2.4.