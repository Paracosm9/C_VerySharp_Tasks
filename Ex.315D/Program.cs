namespace Ex._315D;

class Program
{	
	/**
	 * Program, that shows some statistics about the text, that user enters;
	 */
	static void Main(string[] args)
	{
		Console.WriteLine("Enter your text: ");

		string text = Console.ReadLine();

		int amount = CountAmountOfWords(text);
		string longestWord = GetTheLongestWord(text);
		string wordWithMostVowels = GetTheWordWithMostVowels(text); 
		
		Console.WriteLine($"Amount of words is {amount}.\nYour longest word is {longestWord}.\n Word with most vowels is {wordWithMostVowels}");
	}
	/**
	 * Counts amount of words in text;
	 * @return amount of words in text. 
	 */
	static int CountAmountOfWords(string text)
	{
		string[] words = text.Split(' ');
		Console.WriteLine(words.ToString());
		return words.Length;
	}
	/**
	 * Gets the longest word in text. 
	 * @return the longest word in presented text
	 */
	static string GetTheLongestWord(string text)
	{
		string longestWord = "";
		int maxLength = 0;
		string[] words = text.Split(' ');
		foreach (string word in words)
		{
			if (word.Length > maxLength)
			{
				maxLength = word.Length;
				longestWord = word;
				
			}
		}

		return longestWord;
	}
	/**
	 * Method loops through text, and defines word with most vowels.
	 * @return word with most vowels
	 */
	static string GetTheWordWithMostVowels(string text)
	{
		string[] words = text.Split(' ');
		int amountOfVowels = 0;
		int prevAmount = 0; 
		string wordWithMostVowel = "";
		foreach (string word in words)
		{
			for (int i = 0; i < word.Length; i++)
			{
				if (IsVowel(word[i]))
				{
					amountOfVowels++;
				}
			}

			if (amountOfVowels > prevAmount)
			{
				wordWithMostVowel = word;
			} 
			prevAmount = amountOfVowels; 
			amountOfVowels = 0;
		}

		return wordWithMostVowel;
	}
	
	/**
	 * Defines if character is vowel.
	 */
	static bool IsVowel(char letter)
	{

		return (letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'
		        || letter == 'a' || letter == 'ø' ||
		        letter == 'æ' || letter == 'å' || letter == 'y'
		        ||
		        letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U'
		        || letter == 'A' || letter == 'Ø' || letter == 'Æ' || letter == 'Å' || letter == 'Y'); 
	}
}