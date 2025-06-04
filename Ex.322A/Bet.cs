namespace Ex._322A;

public class Bet(string bet)
{
	private string _bet = bet;

	public void ShowResult(string matchResult)
	{
		var isBetCorrect = _bet.Contains(matchResult);
		var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
		Console.WriteLine($"Du tippet {isBetCorrectText}");
	}
}