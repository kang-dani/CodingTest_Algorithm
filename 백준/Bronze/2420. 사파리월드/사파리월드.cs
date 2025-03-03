using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] numbers = input.Split(' ');
			long n = int.Parse(numbers[0]);
			long m = int.Parse(numbers[1]);

			Console.WriteLine(Math.Abs(n - m));
		}
	}
}
