using System.Text.RegularExpressions;

namespace Ex._316A;

class Program
{
	private const string filename = "/home/lemni/Projects/GetAcademy/C_omg_so_sharp/Excersices/Ex.316A/ordliste.txt";
	static readonly Random Random = new Random();
	
	static void Main(string[] args)
	{
		List<string> allFromFile = ReadFile();
		CheckForSpecialWordsAndShowResult(allFromFile);
	}

	static List<string> ReadFile()
	{
		List<string> justWordsFromDictionary = new List<string>();
		if (File.Exists(filename))
		{
			string[] lines = File.ReadAllLines(filename);
			foreach (var line in lines)
			{
				string oneWord = ReturnFixedString(line);
				if (justWordsFromDictionary.LastOrDefault() != oneWord &&
				    IsCorrectWord(oneWord)) //https://stackoverflow.com/questions/1246918/how-can-i-find-the-last-element-in-a-list
				{
					justWordsFromDictionary.Add(oneWord);
				}
			}
		}
		else
		{
			Console.WriteLine("No file sorry");
		}
		return justWordsFromDictionary;
	}


	static string ReturnFixedString(string oneLine)
	{
		string theWord = oneLine.Split("\t")[1];
		return theWord.Trim().ToLower();
	}

	static bool IsCorrectWord(string word)
	{
		return Regex.IsMatch(word, @"^[\p{L}]+$") && (word.Length is >= 7 and <= 10);
	}

	static void CheckForSpecialWordsAndShowResult(List<String> pureWords)
	{
		List<String[]> foundedPairs = new List<string[]>();
		while (foundedPairs.Count < 200)
		{
			int randomWordIndex = Random.Next(0, pureWords.Count);
			string chosenWord = pureWords[randomWordIndex];
			String[] pair = CheckForPairs(chosenWord, pureWords);
			if (pair.Length > 0)
			{
				foundedPairs.Add(pair);
			}
		}
		int iterator = 1;
		foreach (String[] pair in foundedPairs)
		{
			Console.WriteLine($"{iterator}: {pair[0]} - {pair[1]}");
			iterator++;
		}
	}

	static String[] CheckForPairs(String chosenWord, List<String> pureWords)
	{
		int startLength = 3;
		int iterator = 0;
		while (startLength <= 5)
		{
			string part = chosenWord.Substring(chosenWord.Length - startLength);
			for (int i = 0; i < pureWords.Count; i++)
			{
				if (part == pureWords[i].Substring(0, startLength))
				{
					return new[]
					{ chosenWord, pureWords[i] }; 
				}
				
			}
			startLength += 1;
		}
		return
		[];
	}
}