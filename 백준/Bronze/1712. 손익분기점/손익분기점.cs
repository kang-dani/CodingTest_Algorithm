using System;
using System.Collections.Generic;
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
			string[] inputNum = input.Split(' ');
			long fixedCost = int.Parse(inputNum[0]);
			long variableCost = int.Parse(inputNum[1]);
			long laptopCost = int.Parse(inputNum[2]);
			long laptopCount = 1;

			if (laptopCost > variableCost) laptopCount = (fixedCost / (laptopCost - variableCost)) + 1;
			else laptopCount = -1;
			Console.WriteLine(laptopCount);
		}
	}
}
