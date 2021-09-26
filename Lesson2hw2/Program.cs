using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2hw2
{
	class Program
	{
		static void Main(string[] args)
		{

			int a = 10; //=> 15
			int b = 15; //=> 20
			int c = 20; //=> 10

			a = a ^ c;
			c = a ^ c;
			a = a ^ c;

			a = a ^ b;
			b = a ^ b;
			a = a ^ b;


			// awesome - C# has destructurization :D 
			// best solution

			// (a, b, c) = (b, c, a);

			Console.WriteLine($"New a value: {a}");
			Console.WriteLine($"New b value: {b}");
			Console.WriteLine($"New c value: {c}");

			Console.ReadKey();
		}
	}
}
