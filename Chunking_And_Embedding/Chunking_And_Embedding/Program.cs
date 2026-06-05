using AIConceptSimulator.Services;
using ChunkingAndEmbedding.Services;

Console.WriteLine("Enter Text:");

string input = Console.ReadLine();

TokenizerService.Run(input);

ChunkingService.Run(input);

EmbeddingService.Run(input);

SimilarityService.Run(input);

RagService.Run(input);