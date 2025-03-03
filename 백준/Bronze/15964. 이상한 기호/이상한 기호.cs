using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public long Cal()
		{
			string number = Console.ReadLine();
			string[] numbers = number.Split(' ');
			long a = int.Parse(numbers[0]);
			long b = int.Parse(numbers[1]);
			long result = ((a + b) * (a - b));
			return result;
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			Console.WriteLine(p.Cal());
		}
	}
}
