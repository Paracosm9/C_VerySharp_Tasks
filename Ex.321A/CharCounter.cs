namespace Ex._321A;

public class CharCounter
{
	private static int range = 250;
	public int[] Counts = new int[range];

	public void AddText(string text)
	{
		foreach (var character in text ?? string.Empty)
		{
			Counts[(int)character]++;
		}
	}

	public void ShowCounts()
	{
		for (var i = 0; i < range; i++)
		{
			if (Counts[i] > 0)
			{
				var character = (char)i;
				Console.WriteLine(character + " - " + Counts[i]);
			}
		}
	}
}