using System;
using System.Collections.Generic;
using System.Text;

namespace ChunkingAndEmbedding.Services
{
	public static class ChunkingService
	{
		public static void Run(string text)
		{
			Console.WriteLine();
			Console.WriteLine("=============CHUNKING=============");

			string[] chunks = text.Split("\n\n", StringSplitOptions.RemoveEmptyEntries);

			int ChunkSize = 3;

			for(int i = 0; i < chunks.Length; i+=ChunkSize) 
			{
				string chunk = string.Join("\n\n", chunks.Skip(i).Take(ChunkSize));
				Console.WriteLine(chunk);
			}
		}
	}
}
