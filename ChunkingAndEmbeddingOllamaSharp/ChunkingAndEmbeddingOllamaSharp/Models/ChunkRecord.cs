namespace ChunkingAndEmbeddingOllamaSharp.Models
{
	public class ChunkRecord
	{
		public int Id { get; set; }
		public string Chunk { get; set; } = string.Empty;
		public IEnumerable<float> Vector { get; set; }= Enumerable.Empty<float>();
	}
}