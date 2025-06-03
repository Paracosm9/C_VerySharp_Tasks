namespace Ex._322B;

public class TwelveMatches
{
	public string[] _bets;
	private readonly Match[] _matches;
	private int _correctCount; 

	public TwelveMatches(string[] bets)
	{
		_bets = bets;
		_matches = new Match[3];
		for (var i = 0; i < 3; i++)
		{
			_matches[i] = new Match(new Bet(_bets[i]));
			_matches[i].Run();
		}
	}

	public Match[] getMatches()
	{
		return _matches;
	}

	public void AddGoal(int matchNumber, bool team)
	{
		_matches[matchNumber].AddGoal(team);
	}


	public void ShowAllScores()
	{
		var correctCount = 0;
		for (var index = 0; index < _matches.Length; index++)
		{
			var match = _matches[index];
			var theMatchNo = index + 1;
			var isBetCorrect = match._bet.IsBetCorrect(match.Result);
			var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
			Console.WriteLine($"Kamp {theMatchNo}: {match.GetScore()} - {isBetCorrectText}");
		}
	}

	public void ShowCorrectCounts()
	{
		int correctCount = 0;
		foreach (var match in _matches)
		{
			if (match._bet.IsBetCorrect(match.Result))
			{
				correctCount++;
			}
		}
		Console.WriteLine($"Du har {correctCount} rette."); 
	}
}