namespace Ex._322A_v2;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Gyldig tips: \n" +
		             " - H, U, B\n" + 
		             " - halvgardering: HU, HB, UB\n" + 
		             " - helgardering: HUB\n" + 
		             "Hva har du tippet for denne kampen? ");
		var bet = Console.ReadLine();
		FootbalMatch footbalMatch = new FootbalMatch();
		while (footbalMatch.IsRunning())
		{
			Console.Write("Kommandoer: \n" + 
			              " - H = scoring hjemmelag\n" + 
			              " - B = scoring bortelag\n" + 
			              " - X = kampen er ferdig\n" + 
			              "Angi kommando: ");
			var command = Console.ReadLine();
			if (command == "X")
			{
				footbalMatch.StopMatch();
			};
			if (command == "H") footbalMatch.IncreaseHomeGoal();
			else if (command == "B") footbalMatch.IncreaseOpponentGoal();
			Console.WriteLine($"Stillingen er {footbalMatch.GetScore()}");
		}
		
		var isBetCorrect = bet.Contains(footbalMatch.GetResult());
		var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
		Console.WriteLine($"Du tippet {isBetCorrectText}");
	}
}