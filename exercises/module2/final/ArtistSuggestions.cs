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
