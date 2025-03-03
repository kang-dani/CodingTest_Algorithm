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
			string word = Console.ReadLine();
			int index = int.Parse(Console.ReadLine());

			Console.WriteLine(word[index - 1]);

		}
	}
}
