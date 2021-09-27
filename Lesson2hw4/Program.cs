using System;

namespace Lesson2hw4
{
	class Program
	{
		static void Main(string[] args)
		{
			ShowGreatings();
			CalcMinMaxValues();
		}

		static void ShowGreatings()
		{
			Console.WriteLine("Hello! Yoy must enter 5 values...");
			Console.WriteLine("Ready? Press any key to start.");

			Console.ReadKey();
		}

		static int InputValue(int pos)
		{
			Console.WriteLine($"Enter your {pos} number:");

			string input = Console.ReadLine();

			if (!int.TryParse(input, out int value))
			{
				Console.WriteLine("Sorry can't parse value. You are sure what your typed value a number?. Try again...");

				return InputValue(pos);
			}

			return value;
		}

		static void CalcMinMaxValues()
		{
			int n = 5;
			int max = int.MinValue;
			int min = int.MaxValue;

			for (var i = 0; i < n; ++i)
			{
				int input = InputValue(i + 1);

				if (input < min)
				{
					min = input;
				}

				if (input > max)
				{
					max = input;
				}
			}

			Console.WriteLine("--------------------");
			Console.WriteLine($"Min value: {min}");
			Console.WriteLine($"Max value: {max}");

			Console.ReadKey();
		}
	}
}
