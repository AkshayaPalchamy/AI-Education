using ChunkingAndEmbeddingOllamaSharp.Models;
using Microsoft.Extensions.AI;
using OllamaSharp;
using System.Text.Json;

var document =
"""
PostgreSQL is an open-source relational database management system.

RabbitMQ is a message broker used in microservices.

Embeddings convert text into vectors.

Chunking splits large documents into smaller pieces.
""";

//chunking
var Chunks = document.Split("\n\n", StringSplitOptions.RemoveEmptyEntries);
foreach(var chunk in Chunks)
{
	Console.WriteLine(chunk);
};

//Ollama Connection
var Ollama = new OllamaApiClient(new Uri("http://localhost:11434"),"nomic-embed-text");

//Genetrate Embeddings
var Records = new List<ChunkRecord>();

int id = 1;
foreach(var chunk in Chunks)
{
    Console.WriteLine($"Embedding Chunk {id}...");
    
    var vector = await Ollama.EmbedAsync(chunk);

    var Embedding = vector.Embeddings.First();

	Console.WriteLine($"Chunk Length : {chunk.Length}");
    
    Records.Add(
        new ChunkRecord
        {
            Id = id++,
            Chunk = chunk,
            Vector = Embedding
		});
    foreach(var value in Embedding.Take(10))
    {
        Console.WriteLine(Embedding);
    }
}

var json = JsonSerializer.Serialize(Records, new JsonSerializerOptions
{
	WriteIndented = true
});

await File.WriteAllTextAsync("chunk_records.json", json);

Console.WriteLine("Chunk records saved to chunk_records.json");