namespace Ex._322A;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Gyldig tips: \n" +
		              " - H, U, B\n" + 
		              " - halvgardering: HU, HB, UB\n" + 
		              " - helgardering: HUB\n" + 
		              "Hva har du tippet for denne kampen? ");
		var bet = new Bet(Console.ReadLine());
		var match = new Match();
		match.Run();
		bet.ShowResult(match.Result);
	}
}