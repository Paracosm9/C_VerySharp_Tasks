namespace Ex._315C;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter text to reverse: ");
		Console.WriteLine(ReverseText(Console.ReadLine()));
	}
	
	/**
	 * Method returns reversed string. 
	 * @param string text - text to reverse; 
	 */
	static string ReverseText(string text)
	{
		string reversedText = ""; 
		for (int i = text.Length - 1; i >= 0; i--)
		{
			reversedText += text[i]; 
		}
		return reversedText; 
	}
}