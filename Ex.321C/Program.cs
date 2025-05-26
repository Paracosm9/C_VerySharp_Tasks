namespace Ex._321C;

class Program
{
	static void Main(string[] args)
	{
		Coin[] coinCounts = new Coin[]
		{ new Coin(1, 7),
		  new Coin(5, 3),
		  new Coin(10, 2),
		  new Coin(10, 11) };
		int wholeAmount = 0;
		foreach (Coin coin in coinCounts)
		{
			wholeAmount += new CoinCounter(coin).GetAmountOfCoins();
		}
		
		Console.WriteLine("The whole amount of coins here is: " + wholeAmount);
	}
}