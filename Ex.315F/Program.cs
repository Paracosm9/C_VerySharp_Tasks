namespace Ex._315F;

class Program
{
	static void Main(string[] args)
	{
		int[,] grid =
		{ { 1, 0, 2 },
		  { 3, 4, 5 },
		  { 6, 7, 8 } };
		GamePlay(grid);
	}

	static void GamePlay(int[,] grid)
	{
		while (true)
		{
			showTheBoardGame(grid);
			Console.WriteLine("Enter the number to swap with zero");
			string input = Console.ReadLine();
			int [] coordinates = parseCoordinates(input, grid);
			grid = changePlacesIfPossible(grid, coordinates);
			if (isGameEnd(grid))
			{
				break;
			}
		}

		Console.WriteLine("You won the game!");
	}

	static void showTheBoardGame(int[,] grid)
	{
		int length = grid.GetLength(0);
		string row = ""; 
		for (int i = 0; i < length ; i++)
		{
			for (int j = 0; j < length ; j++)
			{
				row += $"|{grid[i, j]}|";
			}

			Console.WriteLine(row);
			row = "";
		}
	}

	static int[] parseCoordinates(string input,int[,] grid)
	{
		int number = int.Parse(input.Split(' ')[0]);
		int length = grid.GetLength(0);
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length; j++)
			{
				if (number == grid[i, j])
				{
					return [ i, j ];
				}
			}
		}
		return [];
	}

	static int[,] changePlacesIfPossible(int[,] grid, int[] coordinates)
	{
		int[] zeroPosition = parseCoordinates("0", grid);
		if (isPossibleToSwap(zeroPosition, coordinates))
		{
			grid = swapZeroWithNumber(zeroPosition, coordinates, grid);
		}
		return grid;
	}

	static bool isPossibleToSwap(int[] zeroPosition, int[] coordinates)
	
	{
		int zeroX = zeroPosition[0];
		int zeroY = zeroPosition[1];
		int swapX = coordinates[0];
		int swapY = coordinates[1];
		return (
			(zeroX == swapX - 1 && zeroY == swapY || zeroX == swapX + 1 && zeroY == swapY) ||
			(zeroY == swapY - 1 && zeroX == swapX || zeroY == swapY + 1 && zeroX == swapX));
	}

	static int[,] swapZeroWithNumber(int[] zeroPosition, int[] coordinates, int[,] grid)
	{
		int tempZero  = grid[zeroPosition[0], zeroPosition[1]];
		grid[zeroPosition[0], zeroPosition[1]] = grid[coordinates[0], coordinates[1]];
		grid[coordinates[0], coordinates[1]] = tempZero;
		return grid;
	}

	static bool isGameEnd(int[,] grid)
	{
		return grid[0, 0] == 0 && grid[0, 1] == 1 &&
		       grid[0, 2] == 2 && grid[1, 0] == 3 &&
		       grid[1, 1] == 4 && grid[1, 2] == 5 &&
		       grid[2, 0] == 6 && grid[2, 1] == 7 &&
		       grid[2, 2] == 8;
	}
}

