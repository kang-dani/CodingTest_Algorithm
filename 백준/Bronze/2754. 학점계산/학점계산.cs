using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string score = Console.ReadLine();
			double resultScore = 0;
			string alpha = score.Substring(0, 1);

			if (score.Length != 1)
			{
				string sign = score.Substring(1, 1);
				switch (sign)
				{
					case "+":
						resultScore += 0.3;
						break;
					case "-":
						resultScore -= 0.3;
						break;
					default:
						resultScore += 0.0;
						break;
				}
			}
				switch (alpha)
				{
					case "A":
						resultScore += 4.0;
						break;
					case "B":
						resultScore += 3.0;
						break;
					case "C":
						resultScore += 2.0;
						break;
					case "D":
						resultScore += 1.0;
						break;
					default:
						resultScore = 0.0;
						break;	
				}

			Console.WriteLine(resultScore.ToString("F1"));

		}
	}
}
