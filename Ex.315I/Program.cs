using System;
using System.Net.Security;
using System.Text.RegularExpressions;

namespace Ex315I
{
	class Program
	{
		static readonly Random Random = new Random();

		static void Main(string[] args)
		{
			if (!IsValid(args))
			{
				showMessageAndExit();
				return;
			}

			string pattern = createPattern(args[0]);
			createPassword(args, pattern);
		}


		static void createPassword(string[] args, string pattern)
		{
			Int32.TryParse(args[0], out int length);
			int largeLetters = 0;
			makePassword(args, pattern);
		}

		
		static void makePassword(string[] args, string pattern)
		{
			string password = "";
			while (pattern.Length > 0)
			{
				int[] amountOfSymbols = symbolsToAdd(password, args[1]);
				int rnd = Random.Next(amountOfSymbols[0], amountOfSymbols[1]);
				if (rnd == 0)
				{
					password += WriteRandomLowerCaseLetter();
					pattern = pattern.Substring(0, pattern.Length - 1);
				}
				else if (rnd == 1)
				{
					password += WriteRandomUpperCaseLetter();
					pattern = pattern.Substring(0, pattern.Length - 1);
				}
				else if (rnd == 2)
				{
					password += WriteRandomDigit();
					pattern = pattern.Substring(0, pattern.Length - 1);
				}
				else if (rnd == 3)
				{
					password += WriteRandomSpecialCharacter();
					pattern = pattern.Substring(0, pattern.Length - 1);
				}


				Console.WriteLine($"{password}  -this is password");
				Console.WriteLine($"{pattern}  -this is pattern");
			}
		}

		static int[] symbolsToAdd(string password, string setting)
		{
			if (!hasEnoughSymbols(password, setting, 'l'))
			{
				return
					new int[]
					{ 0, 0 };
			}

			else if (!hasEnoughSymbols(password, setting, 'd'))
			{
				return
					new int[]
					{ 2, 2 };
			}
			else if (!hasEnoughSymbols(password, setting, 's'))
			{
				return
					new int[]
					{ 3, 3 };
			}
			else if (!hasEnoughSymbols(password, setting, 'L'))
			{
				return
					new int[]
					{ 1, 1 };
			}

			return
				new int[]
				{ 0, 4 };
		}

		static char WriteRandomLowerCaseLetter()
		{
			return (char)('a' + Random.Next(0, 26));
		}

		static char WriteRandomUpperCaseLetter()
		{
			return (char)('A' + Random.Next(0, 26));
		}

		static string WriteRandomDigit()
		{
			return Random.Next(0, 9).ToString();
		}

		static char WriteRandomSpecialCharacter()
		{
			string specialSymbols = "(!\"#¤%&/(){}[]";
			char[] specialSymbolsArray = specialSymbols.ToCharArray();
			return specialSymbolsArray[Random.Next(0, specialSymbolsArray.Length)];
		}

		static bool IsValid(string[] args)
		{
			if (args.Length > 0 && Int32.TryParse(args[0], out _) && IsStringCorrect(args[1]))
			{
				Console.WriteLine(args[1]);
				return true;
			}

			return false;
		}
		static bool hasEnoughSymbols(string password, string setting, char symbol)
		{
			int amountOfSymbols = 0;
			for (int i = 0; i < setting.Length; i++)
			{
				if (setting[i] == symbol)
				{
					amountOfSymbols++;
				}
			}

			int checker = 0;
			for (int i = 0; i < password.Length; i++)
			{
				if (symbol == 'L' && Char.IsUpper(password[i]))
				{
					checker++;
				}
				else if (symbol == 'd' && Char.IsDigit(password[i]))
				{
					checker++;
				}
				else if (symbol == 'l' && Char.IsLower(password[i]))
				{
					checker++;
				}
				else if (symbol == 's' && "(!\"#¤%&/(){}[]".Contains(password[i]))
				{
					checker++;
				}
			}
			
			return amountOfSymbols <= checker;
		}


		static bool IsStringCorrect(string passwordOptions)
		{
			return Regex.IsMatch(passwordOptions, @"^[Llds]+$");
		}

		static string createPattern(string input)
		{
			Int32.TryParse(input, out int length);
			return new string('*', length);
		}

		static void showMessageAndExit()
		{
			Console.WriteLine(
				"PasswordGenerator  \nOptions:\n- l = liten bokstav\n- L = stor bokstav\n" +
				"- d = siffer\n- s = spesialtegn (!\"#¤%&/(){}[]\nEksempel: PasswordGenerator 14 lLssdd\n    betyr\n        " +
				"Min. 1 liten bokstav\n        Min. 1 1 stor bokstav\n        Min. 2 spesialtegn\n        Min. 2 sifre\n        " +
				"Lengde på passordet skal være 14");
		}
	}
}