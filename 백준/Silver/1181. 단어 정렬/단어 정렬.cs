using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			StreamReader input = new StreamReader(Console.OpenStandardInput());
			StreamWriter output = new StreamWriter(Console.OpenStandardOutput());

			int conv = int.Parse(input.ReadLine().Trim());
			Dictionary<string, int> dictionary = new Dictionary<string, int>();

			for (int i = 0; i < conv; i++)
			{
				string word = input.ReadLine().ToString();
				if(!dictionary.ContainsKey(word))
					dictionary.Add(word, word.Length);
			}

			var sortedDictionary = dictionary.OrderBy(x => x.Value).ThenBy(x => x.Key);

			foreach (var dic in sortedDictionary)
			{
				output.WriteLine(dic.Key);
			}

			output.Close();
			input.Close();
		}
	}
}
