using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public int Cal()
		{
			string num = Console.ReadLine();
			string[] numbers = num.Split(' ');
			int sum = 0;

			for(int i =0; i < numbers.Length; i++)
			{
				int powNum = int.Parse(numbers[i]);
				sum += powNum * powNum;
			}
			return sum % 10;
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			Console.WriteLine(p.Cal());
		}
	}
}
