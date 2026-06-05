using System;
using System.Collections.Generic;
using System.Text;

namespace ChunkingAndEmbedding.Services
{
	public class SimilarityService
	{
		public static void Run(string text)
		{
			Console.WriteLine();
			Console.WriteLine("=============SIMILARITY=============");

			string Reference = "Enbeddings convert text inti  vectors";

			int score = 0;

			foreach(var word in text.ToLower().Split(' '))
			{
				if(Reference.ToLower().Contains(word))
				{
					score++;
				}
			}

			Console.WriteLine($"Similarity Score = {score}");
		}
	}
}
