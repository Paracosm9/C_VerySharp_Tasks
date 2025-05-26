namespace Ex._321B;

class Program
{
	static void Main(string[] args)
	{
		List<FantasyBook> books = GetBooks() ; 
		
		string text = "something";
		while (!string.IsNullOrWhiteSpace(text))
		{
			text = Console.ReadLine();
			foreach (FantasyBook book in books)
			{
				if (book.author.Contains(text) || book.bookName.Contains(text))
				{
					book.ShowData(text);
				}
			}
		}
	}


	static List<FantasyBook> GetBooks()
	{
		return new List<FantasyBook>
		{ new FantasyBook("The Silver Throne 2", "Corwin Hale", 1199, 56, 5),
		  new FantasyBook("The Rune War 2", "Lysa Vane", 576, 18, 3),
		  new FantasyBook("Magebound 2", "Vin Aurel", 836, 95, 4),
		  new FantasyBook("Legends of Arandor 3", "A. K. Winters", 642, 53, 2),
		  new FantasyBook("The Rune War 5", "A. K. Winters", 322, 54, 5),
		  new FantasyBook("The Rune War 4", "Mira Thorn", 1041, 90, 2),
		  new FantasyBook("Whispers of Magic 2", "Nina Krell", 720, 42, 5),
		  new FantasyBook("Magebound 2", "Serena Roth", 1147, 79, 2),
		  new FantasyBook("Kingdom of Ashes 1", "Derek Fen", 497, 48, 4),
		  new FantasyBook("Magebound 5", "T. M. Kade", 820, 84, 3),
		  new FantasyBook("The Silver Throne 4", "Nina Krell", 340, 11, 2),
		  new FantasyBook("Legends of Arandor 1", "A. K. Winters", 788, 26, 4),
		  new FantasyBook("Kingdom of Ashes 2", "J. R. Galen", 1116, 31, 3),
		  new FantasyBook("The Rune War 1", "Lysa Vane", 246, 53, 2),
		  new FantasyBook("Blade of the Ancients 1", "A. K. Winters", 464, 31, 4),
		  new FantasyBook("Magebound 1", "A. K. Winters", 817, 38, 2),
		  new FantasyBook("The Dragon's Call 5", "Nina Krell", 526, 51, 5),
		  new FantasyBook("Legends of Arandor 1", "Mira Thorn", 468, 36, 3),
		  new FantasyBook("Chronicles of Elden 2", "Serena Roth", 475, 45, 1),
		  new FantasyBook("The Rune War 4", "Mira Thorn", 1143, 61, 4),
		  new FantasyBook("The Rune War 1", "J. R. Galen", 241, 15, 1),
		  new FantasyBook("The Silver Throne 5", "Lysa Vane", 1102, 39, 2),
		  new FantasyBook("The Silver Throne 4", "Lysa Vane", 283, 43, 2),
		  new FantasyBook("Shadows of Myth 1", "Serena Roth", 503, 80, 2),
		  new FantasyBook("Magebound 4", "A. K. Winters", 474, 67, 3),
		  new FantasyBook("The Silver Throne 1", "T. M. Kade", 751, 71, 3),
		  new FantasyBook("Whispers of Magic 5", "J. R. Galen", 810, 22, 4),
		  new FantasyBook("Whispers of Magic 5", "J. R. Galen", 1080, 43, 4),
		  new FantasyBook("Chronicles of Elden 3", "A. K. Winters", 215, 72, 5),
		  new FantasyBook("The Silver Throne 5", "Derek Fen", 872, 24, 3),
		  new FantasyBook("Shadows of Myth 3", "J. R. Galen", 807, 32, 2),
		  new FantasyBook("Shadows of Myth 1", "Lysa Vane", 422, 68, 4),
		  new FantasyBook("The Dragon's Call 2", "Mira Thorn", 526, 89, 4),
		  new FantasyBook("Chronicles of Elden 3", "Corwin Hale", 747, 39, 4),
		  new FantasyBook("Magebound 3", "Nina Krell", 282, 51, 2),
		  new FantasyBook("Chronicles of Elden 3", "Vin Aurel", 925, 87, 1),
		  new FantasyBook("Whispers of Magic 4", "Vin Aurel", 814, 61, 5),
		  new FantasyBook("Shadows of Myth 4", "Vin Aurel", 673, 22, 1),
		  new FantasyBook("Chronicles of Elden 3", "J. R. Galen", 795, 80, 2),
		  new FantasyBook("The Rune War 1", "T. M. Kade", 640, 40, 2),
		  new FantasyBook("The Silver Throne 4", "Corwin Hale", 1149, 32, 1),
		  new FantasyBook("Blade of the Ancients 3", "Serena Roth", 1103, 14, 2),
		  new FantasyBook("The Silver Throne 3", "Mira Thorn", 598, 39, 1),
		  new FantasyBook("Magebound 1", "Nina Krell", 1087, 31, 4),
		  new FantasyBook("Legends of Arandor 3", "T. M. Kade", 279, 60, 2),
		  new FantasyBook("Chronicles of Elden 1", "Serena Roth", 1149, 35, 1),
		  new FantasyBook("Blade of the Ancients 3", "Mira Thorn", 778, 86, 4),
		  new FantasyBook("The Rune War 1", "T. M. Kade", 819, 89, 4),
		  new FantasyBook("The Silver Throne 3", "Derek Fen", 156, 89, 2),
		  new FantasyBook("Whispers of Magic 1", "Derek Fen", 299, 92, 2),
		  new FantasyBook("Shadows of Myth 3", "Mira Thorn", 974, 79, 1),
		  new FantasyBook("Shadows of Myth 3", "J. R. Galen", 751, 21, 4),
		  new FantasyBook("The Silver Throne 2", "A. K. Winters", 328, 16, 3),
		  new FantasyBook("The Silver Throne 4", "Serena Roth", 1150, 44, 3),
		  new FantasyBook("Shadows of Myth 4", "Mira Thorn", 279, 81, 3),
		  new FantasyBook("The Silver Throne 1", "T. M. Kade", 453, 59, 5),
		  new FantasyBook("Kingdom of Ashes 2", "T. M. Kade", 478, 95, 1),
		  new FantasyBook("Shadows of Myth 1", "Vin Aurel", 1159, 60, 2),
		  new FantasyBook("Blade of the Ancients 3", "Mira Thorn", 916, 85, 2),
		  new FantasyBook("The Dragon's Call 1", "Derek Fen", 1005, 86, 2),
		  new FantasyBook("The Rune War 5", "Lysa Vane", 634, 90, 1),
		  new FantasyBook("The Rune War 5", "Lysa Vane", 439, 59, 3),
		  new FantasyBook("Shadows of Myth 5", "Derek Fen", 1124, 57, 4),
		  new FantasyBook("Whispers of Magic 1", "Mira Thorn", 196, 61, 5),
		  new FantasyBook("The Dragon's Call 4", "T. M. Kade", 900, 19, 3),
		  new FantasyBook("Legends of Arandor 5", "A. K. Winters", 505, 12, 2),
		  new FantasyBook("Whispers of Magic 5", "A. K. Winters", 298, 35, 2),
		  new FantasyBook("Blade of the Ancients 1", "T. M. Kade", 862, 92, 4),
		  new FantasyBook("Blade of the Ancients 4", "J. R. Galen", 826, 74, 4),
		  new FantasyBook("The Dragon's Call 5", "A. K. Winters", 582, 29, 5),
		  new FantasyBook("Magebound 4", "A. K. Winters", 652, 77, 3),
		  new FantasyBook("Shadows of Myth 4", "Vin Aurel", 339, 68, 3),
		  new FantasyBook("Magebound 1", "A. K. Winters", 366, 21, 2),
		  new FantasyBook("Whispers of Magic 5", "J. R. Galen", 409, 66, 1),
		  new FantasyBook("Legends of Arandor 4", "Lysa Vane", 714, 20, 5),
		  new FantasyBook("Blade of the Ancients 4", "Lysa Vane", 632, 36, 5),
		  new FantasyBook("Chronicles of Elden 1", "A. K. Winters", 199, 48, 2),
		  new FantasyBook("Legends of Arandor 5", "Lysa Vane", 200, 64, 2),
		  new FantasyBook("Kingdom of Ashes 1", "T. M. Kade", 1108, 88, 1),
		  new FantasyBook("The Dragon's Call 1", "Vin Aurel", 1109, 72, 5),
		  new FantasyBook("The Silver Throne 1", "J. R. Galen", 282, 96, 3),
		  new FantasyBook("Shadows of Myth 1", "Mira Thorn", 987, 97, 3),
		  new FantasyBook("Blade of the Ancients 2", "Derek Fen", 326, 55, 4),
		  new FantasyBook("Kingdom of Ashes 3", "Serena Roth", 1170, 34, 3),
		  new FantasyBook("The Rune War 4", "Mira Thorn", 611, 27, 3),
		  new FantasyBook("Legends of Arandor 4", "A. K. Winters", 878, 35, 4),
		  new FantasyBook("Shadows of Myth 5", "Derek Fen", 929, 36, 3),
		  new FantasyBook("Blade of the Ancients 1", "A. K. Winters", 180, 50, 1),
		  new FantasyBook("The Silver Throne 1", "Lysa Vane", 742, 78, 2),
		  new FantasyBook("Legends of Arandor 4", "Nina Krell", 1078, 23, 1),
		  new FantasyBook("Whispers of Magic 5", "J. R. Galen", 676, 93, 2),
		  new FantasyBook("Shadows of Myth 1", "Serena Roth", 899, 58, 5),
		  new FantasyBook("Kingdom of Ashes 1", "Corwin Hale", 162, 96, 5),
		  new FantasyBook("Legends of Arandor 4", "A. K. Winters", 526, 67, 1),
		  new FantasyBook("Chronicles of Elden 5", "Serena Roth", 1110, 59, 5),
		  new FantasyBook("Kingdom of Ashes 2", "Corwin Hale", 760, 56, 4),
		  new FantasyBook("Shadows of Myth 2", "Corwin Hale", 450, 65, 3),
		  new FantasyBook("The Dragon's Call 1", "Derek Fen", 1165, 66, 2),
		  new FantasyBook("Legends of Arandor 4", "T. M. Kade", 845, 52, 2),
		  new FantasyBook("The Silver Throne 4", "A. K. Winters", 1093, 66, 5), };
	}
}