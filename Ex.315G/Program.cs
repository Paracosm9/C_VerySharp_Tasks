namespace Ex._315G;

class Program
{        
	static void Main(string[] arguments)
	{
		var range = 250;
		var counts = new int[range];
		string text = "something";
		int fullAmount = 0; 
		while (!string.IsNullOrWhiteSpace(text))
		{
			text = Console.ReadLine();
			foreach (var character in text)
			{
				counts[(int)Char.ToLower(character)]++;
			}
			
			for (var i = 0; i < range; i++)
			{
				if (counts[i] > 0)
				{
					fullAmount+= counts[i];
				}
			}
			for (var i = 0; i < range; i++)
			{
				if (counts[i] > 0)
				{
					var character = (char)i;
					Console.WriteLine(character + " - " + counts[i] + " - percent: " + (int)((double)counts[i] / (double)fullAmount * 100) + "%");
				}
			}
		}
	}
}