namespace Ex._315B;

/**
 *
 Oppgave 153 C   Skriv en funksjon som kan krypterer en tekst i store bokstaver ved hjelp av et enkelt subsitutsjonscipher. For å krypfor eksempel en T må du slå opp posisjonen til T i alfabetet (se under) - og så finne bokstaven på samme posisjon i den hemmelige koden. TERJE kryptert skal for eksempel bli MUKBU.
   Alfabet       ABCDEFGHIJKLMOPQRSTUVWXYZÆØÅ
   Hemmelig kode ÅØÆYUOIEABCDFGHJKLMPQRSTVWXZ
 */
class Program153c
{
	static void Main(string[] args)
	{
		const string alphabet = "ABCDEFGHIJKLMOPQRSTUVWXYZÆØÅ";
		const string cypherCode = "ÅØÆYUOIEABCDFGHJKLMPQRSTVWXZ";
		char[] alphabetArray = alphabet.ToCharArray();
		char[] cypherArray = cypherCode.ToCharArray();
		Console.WriteLine("Enter word to cypher");
		string wordToCypher = Console.ReadLine();
		Console.WriteLine(
			$"Word {wordToCypher} is coded as: {CypherDecypherText(wordToCypher, alphabetArray, cypherArray)}");
	}

	static string CypherDecypherText(string text, char[] alphabet, char[] code)
	{
		string cypheredText = "";
		foreach (var chr in text)
		{
			cypheredText += ReturnCoded(chr, alphabet, code);
		}

		return cypheredText;
	}

	static char ReturnCoded(char symbol, char[] alphabet, char[] code)
	{
		char upperChar = Char.ToUpper(symbol);
		for (int i = 0; i < alphabet.Length; i++)
		{
			if (alphabet[i] == upperChar)
			{
				return code[i];
			}
		}

		return ' ';
	}
}