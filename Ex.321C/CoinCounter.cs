namespace Ex._321C;

public class CoinCounter(Coin coin)
{
	private Coin _coin = coin;

	public int GetAmountOfCoins()
	{
		return _coin.Value * _coin.Count;
	}
}