namespace ChunkingAndEmbedding.Services
{
	public static class TokenizerService
	{
		public static void Run(string text)
		{
			Console.WriteLine();
			Console.WriteLine("===========Tokenizer==========");

			string[] Tokens = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);

			foreach(var Token in Tokens) 
			{
				Console.WriteLine(Token);
			}
		}
	}
}
