using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2hw1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CustomXOR(0, 0)); // false
			Console.WriteLine(CustomXOR(1, 0)); // true
			Console.WriteLine(CustomXOR(0, 1)); // true
			Console.WriteLine(CustomXOR(1, 1)); // false

			Console.ReadKey();
		}

		static bool CustomXOR(int a, int b)
		{
			bool x = Convert.ToBoolean(a);
			bool y = Convert.ToBoolean(b);

			return !x && y || x && !y;
		}
	}
}
