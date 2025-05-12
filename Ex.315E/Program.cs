namespace Ex._315E;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter start number: ");
		int start = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter end number: ");
		int end = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter step number: ");
		int step = int.Parse(Console.ReadLine());
		
		int[] numbers = CreateNumbersWithStep(start, end, step);

		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine(numbers[i]);
		}
	}

	static int[] CreateNumbersWithStep(int start, int end, int step)
	{
		int[] numbers = new int[(end - start) / step + 1];
		int index = 0;
		for (int i = start; i <= end; i+=step)
		{
			numbers[index++] = i;
		}
		return numbers;
	}
	
}