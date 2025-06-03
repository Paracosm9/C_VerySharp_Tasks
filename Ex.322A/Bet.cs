namespace Ex._322A;

public class Bet
{
	private string _bet;

	public Bet(string bet)
	{
		_bet = bet;
	}

	public void ShowResult(string matchResult)
	{
		var isBetCorrect = _bet.Contains(matchResult);
		var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
		Console.WriteLine($"Du tippet {isBetCorrectText}");
	}
}