namespace Ex._322A;

public class Match
{
	private int _homeGoals { get; set; }
	private int _awayGoals { get; set; }
	private Boolean _matchIsRunning;
	internal string Result { get; set; }

	public void Run()
	{
		_homeGoals = 0;
		_awayGoals = 0;
		_matchIsRunning = true;
		while (_matchIsRunning)
		{
			Console.Write("Kommandoer: \n" +
			              " - H = scoring hjemmelag\n" +
			              " - B = scoring bortelag\n" +
			              " - X = kampen er ferdig\n" +
			              "Angi kommando: ");
			var command = Console.ReadLine();
			_matchIsRunning = command != "X";
			if (command == "H") _homeGoals++;
			else if (command == "B") _awayGoals++;
			Console.WriteLine($"Stillingen er {_homeGoals}-{_awayGoals}.");
		}

		Result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
	}
}