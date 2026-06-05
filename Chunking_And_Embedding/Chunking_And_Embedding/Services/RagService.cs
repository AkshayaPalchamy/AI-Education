namespace AIConceptSimulator.Services;

public static class RagService
{
	public static void Run(string query)
	{
		Console.WriteLine();
		Console.WriteLine("===== RAG SEARCH =====");

		string[] chunks =
		{
			"PostgreSQL is a database",

			"RabbitMQ is a message broker",

			"Embeddings convert text into vectors",

			"Chunking splits documents"
		};

		string bestChunk = "";

		int bestScore = 0;

		foreach(var chunk in chunks)
		{
			int score = 0;

			foreach(var word in query.ToLower().Split(' '))
			{
				if(chunk.ToLower().Contains(word))
				{
					score++;
				}
			}

			if(score > bestScore)
			{
				bestScore = score;
				bestChunk = chunk;
			}
		}

		Console.WriteLine($"Retrieved Chunk:");

		Console.WriteLine(bestChunk);
	}
}