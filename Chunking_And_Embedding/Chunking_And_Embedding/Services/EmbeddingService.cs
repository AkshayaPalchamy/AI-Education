using System;
using System.Collections.Generic;
using System.Text;

namespace ChunkingAndEmbedding.Services
{
	public class EmbeddingService
	{
		public static void Run(string input)
		{
			Console.WriteLine("Enter Text");

			string Text = input;

			int Length = Text.Length;

			int words = Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

			int vowels = Text.Count(v => "aeiouAEIOU".Contains(v));

			Console.WriteLine($"Vector = [{Length}, {words}, {vowels}]");
		}
	}
}
