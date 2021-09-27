using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2hw3
{
	class Program
	{
		static void Main(string[] args)
		{
			ShowGreatings();

			int a;
			int b;
			int c;
			int d;
			int e;

			a = InputValue("a");
			b = InputValue("b");
			c = InputValue("c");
			d = InputValue("d");
			e = InputValue("e");


			ShowChoice(a, b, c, d, e);
			CalcMinMaxValues(a, b, c, d, e);
		}

		static void ShowGreatings()
		{
			Console.WriteLine("Hello! Yoy must enter 5 values...");
			Console.WriteLine("Ready? Press any key for start.");

			Console.ReadKey();
		}

		static int InputValue(string variable) {
			Console.WriteLine($"Enter number for {variable}");

			string input = Console.ReadLine();

			if (!int.TryParse(input, out int value)) {
				Console.WriteLine("Sorry can't parse value. You are sure what your typed value a number?. Try again...");

				return InputValue(variable);
			}

			return value;
		}

		static void ShowChoice(int a, int b, int c, int d, int e)
		{
			Console.WriteLine("--------------------");
			Console.WriteLine($"Your choice is: {a}, {b}, {c}, {d}, {e}");
		}

		static void CalcMinMaxValues(int a, int b, int c, int d, int e)
		{
			int min;
			int max;

			if (a < b)
			{
				min = a;
				max = b;
			}
			else
			{
				min = b;
				max = a;
			}

			if (c < min)
			{
				min = c;
			}

			if (c > max)
			{
				max = c;
			}

			if (d < min)
			{
				min = d;
			}

			if (d > max)
			{
				max = d;
			}

			if (e < min)
			{
				min = e;
			}

			if (e > max)
			{
				max = e;
			}

			Console.WriteLine("--------------------");
			Console.WriteLine($"Min value: {min}");
			Console.WriteLine($"Max value: {max}");

			Console.ReadKey();
		}
	}
}
