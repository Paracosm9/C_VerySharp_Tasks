namespace Ex._322C;

public class Square
{
	private bool _isEmpty = true;
	private int _wasTakenByPlayer; //can be 1 or 2. 

	public bool IsEmpty()
	{
		return _isEmpty;
	}

	public int WasTakenByPlayer()
	{
		return _wasTakenByPlayer;
	}

	public void setRoute(bool player)
	{
		if (_isEmpty)
		{
			_wasTakenByPlayer = player ? 1 : 2;
			Console.WriteLine("Player took the square!");
			_isEmpty = false;
		}
	}
}