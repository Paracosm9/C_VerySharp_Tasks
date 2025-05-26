namespace Ex._321B;

public class FantasyBook(string bookName, string author, int amountOfPages, int price, int genre)
{
	internal string bookName = bookName;
	internal string author = author;
	internal int amountOfPages = amountOfPages;
	internal int price = price;
	internal int genre = genre;

	public void ShowData(string text)
	{
		Console.WriteLine("This contains your search value: " + text);
		Console.WriteLine("******************");
		Console.WriteLine("Book Name: " + bookName);
		Console.WriteLine("Book Author: " + author);
		Console.WriteLine("Amount of pages: " + amountOfPages);
		Console.WriteLine("Price: " + price);
		Console.WriteLine("Genre: " + price);
		Console.WriteLine("******************");
	}
}