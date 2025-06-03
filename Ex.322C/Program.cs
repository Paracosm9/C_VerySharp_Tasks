namespace Ex._322C;

class Program
{
	static void Main(string[] args)
	{
		Board board = new Board(); 
		GameConsole gameConsole = new GameConsole();
		gameConsole.Show(board);
		int player = 1; 
		while (true)
		{
			gameConsole.Show(board);
			Console.Write($"Skriv inn hvor du vil sette kryss, {(player % 2 != 0 ? " Player 1" : " Player 2")} (f.eks. \"a2\"): ");
			var position = Console.ReadLine();
			board.Mark(position, player % 2 != 0 );
			player++;
			Thread.Sleep(2000);
			board.MarkRandom(false);
		}
	}
}