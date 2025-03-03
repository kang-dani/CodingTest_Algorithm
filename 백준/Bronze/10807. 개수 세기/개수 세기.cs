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
			int InputCount = int.Parse(Console.ReadLine());
			string inputNumber = Console.ReadLine();
			string keyNum = Console.ReadLine();
			int count = 0;

			string[] numbers = inputNumber.Split(' ');

			for(int i = 0; i < InputCount; i++)
			{
				if(numbers[i] == keyNum)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}
