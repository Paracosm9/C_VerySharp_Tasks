namespace Ex._322B;

public class Bet
{
	private string _bet;

	public Bet(string bet)
	{
		_bet = bet;
	}

	public void ShowResult(string matchResult)
	{
		var isBetCorrectText = IsBetCorrect(matchResult);
		Console.WriteLine($"Du tippet {(isBetCorrectText ? "riktig" : "feil")}");
	}

	public Boolean IsBetCorrect(string matchResult)
	{
		return _bet.Contains(matchResult);
	}
}