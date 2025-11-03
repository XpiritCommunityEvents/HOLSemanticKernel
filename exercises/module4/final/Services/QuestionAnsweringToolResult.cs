using module4.Models;

namespace module4.Services;

public class QuestionAnsweringToolResult
{
    public required string Response { get; set; }
    public required List<TextUnit> Context { get; set; }
}