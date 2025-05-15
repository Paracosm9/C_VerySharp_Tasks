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
			counts = CountChars(counts, text);
			fullAmount = getAmountOfChars(counts, fullAmount, range);
			showResult(counts, fullAmount, range);
			
		}
	}

	static int[] CountChars(int[] counts, string text)
	{
		foreach (var character in text)
		{
			counts[(int)Char.ToLower(character)]++;
		}

		return counts;
	}

	static int getAmountOfChars(int[] counts, int fullAmount, int range)
	{
		
		for (var i = 0; i < range; i++)
		{
			if (counts[i] > 0)
			{
				fullAmount += counts[i];
			}
		}
		return fullAmount;
	}

	static void showResult(int[] counts, int fullAmount, int range)
	{
		for (var i = 0; i < range; i++)
		{
			if (counts[i] > 0)
			{
				var character = (char)i;
				Console.WriteLine(character + " - " + counts[i] + " - percent: " +
				                  (int)((double)counts[i] / (double)fullAmount * 100) + "%");
			}
		}
	}
}