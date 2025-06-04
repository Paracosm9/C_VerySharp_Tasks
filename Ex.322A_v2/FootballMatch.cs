namespace Ex._322A_v2;

public class FootbalMatch
{
	private int _homeGoals = 0;
	private int _awayGoals = 0;
	private bool _isRunning = true;


	public void IncreaseHomeGoal()
	{
		_homeGoals++;
	}
	
	public void IncreaseOpponentGoal()
	{
		_awayGoals++;
	}

	public string GetResult()
	{
		return _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
	}

	public string GetScore()
	{
		return $"{_homeGoals}-{_awayGoals}";
	}

	public bool IsRunning()
	{
		return _isRunning;
	}

	public void StopMatch()
	{
		_isRunning = false;
	}
}