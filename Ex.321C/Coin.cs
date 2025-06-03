namespace Ex._321C;

public class Coin(int value, int count)
{
	private readonly int _value = value;
	private readonly int _count = count;
	
	public int Value => _value;
	public int Count => _count;
}