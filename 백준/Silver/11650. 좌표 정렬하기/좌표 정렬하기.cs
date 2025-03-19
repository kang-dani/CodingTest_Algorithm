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
			Dictionary<int, Tuple<int, int>> Tuples = new Dictionary<int, Tuple<int, int>>();

			for (int i = 0; i < conv; i++)
			{
				string[] numbers = input.ReadLine().Split(' ');
				int _x = int.Parse(numbers[0]);
				int _y = int.Parse(numbers[1]);
				Tuples.Add(i, Tuple.Create(_x, _y));

			}
			var sortedTuples = Tuples.OrderBy(x => x.Value.Item1).ThenBy(x => x.Value.Item2);

			foreach(var tuple in sortedTuples)
			{
				output.WriteLine(tuple.Value.Item1+ " " + tuple.Value.Item2);
			}	

			output.Close();
			input.Close();
		}
	}
}
