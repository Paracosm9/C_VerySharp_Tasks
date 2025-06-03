namespace Ex._322C;

public class GameConsole
{
	public void Show(Board board)
	{	
		Console.Clear();
		string boardString = "  a b c\n ┌─────┐\n";
		int row = 1;
		int col = 1;
		foreach (var square in board.Squares)
		{
			if (col > 3)
			{
				col = 1;
				row++;
			}
			boardString += col == 1 ? row + "│" : "";
			boardString += square.IsEmpty() ? GetCorrectPlacing(col, " ")
				: square.WasTakenByPlayer() == 1 ? GetCorrectPlacing(col, "x") : GetCorrectPlacing(col, "o");

			col++; 
		}
		boardString += " └─────┘";
		Console.WriteLine(boardString);
	}

	private string GetCorrectPlacing(int col, string symbol)
	{
		return col == 3 ? symbol + "│\n" : symbol + " ";
	}
}