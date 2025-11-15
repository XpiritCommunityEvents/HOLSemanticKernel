using System.Text.Json;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace modulerag;

public class ChatWithRag
{
    public async Task RAG_with_single_prompt(Kernel kernel)
    {
        var question = 
        """
        I booked tickets for a concert tonight in venue AFAS Live!.
        I have this small black backpack, not big like for school, more like the mini
        festival type 😅. it just fits my wallet, a hoodie and a bottle of water.
        Is this allowed?
        """;

        var venue = await GetVenueFromQuestion(kernel, question);
        var policyContext = await GetVenuePolicyFileContents(kernel, venue);
        await GetResponseOnQuestion(kernel, question, policyContext);
    }

    private async Task<string> GetVenuePolicyFileContents(Kernel kernel, string venueName)
    {
        //Get a list of files from the venue policy repository
        var directory = "../../../../datasets/venue-policies";
        var fileList = string.Join("\n", System.IO.Directory.GetFiles(directory, "*.md").Select(f => System.IO.Path.GetFileName(f)));
        
        var systemPrompt = "You are an expert at finding the correct file based on a user question.";
        var fileListPrompt = $"The following is a list of files available:\n{fileList}";
        var fileQuestion = $"Which file contains the venue policy for the venue named '{venueName}'?";
        
        var chatHistory = new ChatHistory();
        chatHistory.AddSystemMessage(systemPrompt);
        chatHistory.AddUserMessage(fileListPrompt);
        chatHistory.AddUserMessage(fileQuestion);

        var executionSettings = new OpenAIPromptExecutionSettings
        {
            ResponseFormat = typeof(SelectedFile)
        };

        var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
        
        var fileResult = JsonSerializer.Deserialize<SelectedFile>(result.ToString());
        var fullFileName = Path.Combine(directory, fileResult.File);

        if (System.IO.File.Exists(fullFileName))
        {
            using (var file = File.OpenText(fullFileName))
            {
                return await file.ReadToEndAsync();
            }
        }
        
        return "No Policy information found";
    }

    private async Task<string> GetVenueFromQuestion(Kernel kernel, string question)
    {
        ChatHistory chatHistory = new();

        chatHistory.AddSystemMessage("You are a helpful asistant that finds the name of a venue from a question.");
        chatHistory.AddSystemMessage("Always get the information from the question. Never search the web or use internal knowledge!");
        chatHistory.AddUserMessage(question);
        var executionSettings = new OpenAIPromptExecutionSettings
        {
            ResponseFormat = typeof(SelectedVenue)
        };
        var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        var result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, executionSettings, kernel);
        var selectedVenue = JsonSerializer.Deserialize<SelectedVenue>(result.ToString());
        return selectedVenue!.VenueName;
    }

    private async Task GetResponseOnQuestion(Kernel kernel, string question, string policyContext)
    {
        ChatHistory chatHistory = new();
        chatHistory.AddSystemMessage("You are a helpful assistant that answers questions from people that go to a concert and have questions about the venue.");
        chatHistory.AddSystemMessage("Always use the policy information provided in the prompt");
        chatHistory.AddSystemMessage($"### Venue Policy\n {policyContext}");

        chatHistory.AddUserMessage(question);
        
        var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        var questionResponse = chatCompletionService!.GetStreamingChatMessageContentsAsync(chatHistory, kernel:kernel);
        await foreach (var response in questionResponse)
        {
            Console.Write(response.Content);
        }
    }
}
