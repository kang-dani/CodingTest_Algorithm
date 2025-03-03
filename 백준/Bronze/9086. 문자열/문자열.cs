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
			while(true)
			{
				string word = Console.ReadLine();
				if (string.IsNullOrEmpty(word)) break;
				if (word[0] >= 'A' && word[0] <= 'Z')
					Console.WriteLine(word.Substring(0, 1) + word.Substring(word.Length - 1));
			}

		}
	}
}
