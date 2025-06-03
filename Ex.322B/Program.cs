namespace Ex._322B;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Gyldig tips: \n" +
		              " - H, U, B\n" +
		              " - halvgardering: HU, HB, UB\n" +
		              " - helgardering: HUB\n" +
		              "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
		TwelveMatches twelveMatches = new TwelveMatches(Console.ReadLine().Split(','));

		while (true)
		{
			Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
			var command = Console.ReadLine();
			if (command == "X") break;
			var matchNo = Convert.ToInt32(command);
			Console.Write("Kommandoer: \n" +
			              " - H = scoring hjemmelag\n" +
			              " - B = scoring bortelag\n" +
			              " - X = kampen er ferdig\n" +
			              "Angi kommando: ");
			var team = Console.ReadLine();
			twelveMatches.AddGoal(matchNo, team == "H");
			twelveMatches.ShowAllScores();
			twelveMatches.ShowCorrectCounts();
		}
	}
}