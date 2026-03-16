using Microsoft.Extensions.VectorData;

namespace modulerag;

/// <summary>
/// Class representing a chunk of text from a venue policy file, along with its embedding vector for use in a vector store.
/// Every instance of this class becomes an entry in the a vector store collection
/// </summary>
internal sealed class PolicyFilePart
{
    [VectorStoreKey]
    public ulong Key { get; set; }

    [VectorStoreData(IsIndexed = true)]
    public required string FileName { get; init; }

    [VectorStoreData]
    public required string Chunk { get; init; }

    [VectorStoreVector(1536)]
    public ReadOnlyMemory<float> EmbeddingVector { get; set; }
}
