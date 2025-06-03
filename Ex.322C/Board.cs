namespace Ex._322C;

public class Board
{
	public List<Square> Squares = new List<Square>()
	{
	new Square(),
	new Square(),
	new Square(),
	new Square(),
	new Square(),
	new Square(),
	new Square(),
	new Square(),
	new Square()
	};
	private readonly Random _random = new Random();

	public void Mark(string position, bool player)
	{
		Console.WriteLine(position);
		char[] pieces = position.ToCharArray();
		Console.WriteLine(pieces);
		int row = (int)pieces[1] - '0';
		int col = DefineColumn(pieces[0]);

		int rowInSquares = 1; 
		int colInSquares = 1;
		foreach (var square in Squares)
		{
			if (colInSquares > 3)
			{
				colInSquares = 1;
				rowInSquares++;
			}

			if (rowInSquares == row && colInSquares == col)
			{
				square.setRoute(player);
				break;
			} 
			colInSquares++;
		}
	}

	public void MarkRandom(bool player)
	{
		
	}

	private int DefineColumn(char column)
	{
		int col = 0;
		switch (column)
		{
			case 'a':
				col = 1; 
				break;
			case 'b':
				col = 2;
				break;
			case 'c':
				col = 3;
				break;
		}
		return col;
	}
}