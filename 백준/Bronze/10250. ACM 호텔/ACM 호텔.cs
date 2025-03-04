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
			int condition = int.Parse(Console.ReadLine());
			while (condition != 0)
			{
				condition--;
				string input = Console.ReadLine();
				string[] inputNums = input.Split(' ');
				int height = int.Parse(inputNums[0]);
				int width = int.Parse(inputNums[1]);
				int nCustomer = int.Parse(inputNums[2]);
				int address = 0;
				
				int xx = nCustomer / height + 1;
				int yy = nCustomer % height;

				if (yy == 0)	//꼭대기 층
				{
					xx = nCustomer / height;
					yy = height;
				}
				
				address = xx + yy * 100;

				Console.WriteLine(address);

			}
		}
	}
}
