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
			string inputNum = Console.ReadLine();
			string[] inputNumA = inputNum.Split(' ');
			int n = int.Parse(inputNumA[0]);
			int m = int.Parse(inputNumA[1]);
			int[,] resultArray = new int[n, m];

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				string[] arraySplit = input.Split(' ');

				for (int j = 0; j < m; j++)
				{
					resultArray[i, j] = int.Parse(arraySplit[j]);
				}
			}
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				string[] arraySplit = input.Split(' ');

				for (int j = 0; j < m; j++)
				{
					resultArray[i, j] += int.Parse(arraySplit[j]);
				}
			}			
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(resultArray[i, j] + " ");
				}
				Console.WriteLine();
			}

		}
	}
}
