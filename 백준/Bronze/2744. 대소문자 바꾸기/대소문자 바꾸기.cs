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
			string word = Console.ReadLine();
			string answer = null;
			for(int i = 0; i < word.Length; i++)
			{
				char c = word[i];
				answer += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
			}
			Console.WriteLine(answer);

		}
	}
}
