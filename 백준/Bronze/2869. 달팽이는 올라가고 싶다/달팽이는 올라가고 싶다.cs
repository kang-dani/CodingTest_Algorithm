using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
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
			long aUp = int.Parse(numbers[0]);
			long bDown = int.Parse(numbers[1]);
			long vMeter = int.Parse(numbers[2]);
			long count = (vMeter - aUp) / (aUp - bDown) + 1;

			if ((vMeter - aUp) % (aUp - bDown) != 0) count++;

			Console.WriteLine(count);
		}
	}
}
