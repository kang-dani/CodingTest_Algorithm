using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			// 입력 빠르게 읽기 위해서 StreamReader 채용
			StreamReader input = new StreamReader(Console.OpenStandardInput());
			int conv = int.Parse(input.ReadLine().Trim());
			int[] data = new int[conv];
			StringBuilder output = new StringBuilder();

			for (int i = 0; i < conv; i++)
				data[i] = int.Parse(input.ReadLine().Trim());

			Array.Sort(data);

			foreach (int num in data) output.Append(num).Append("\n");

			Console.WriteLine(output.ToString());
			input.Close();

		}
	}
}