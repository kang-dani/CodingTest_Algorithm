using System;
using System.IO;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			StreamReader input = new StreamReader(Console.OpenStandardInput());
			StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

			int conv = int.Parse(input.ReadLine().Trim());

			// 입력값의 최대 범위를 고려하여 배열 크기 설정 (1~10000 가정)
			int[] data = new int[10001];

			for (int i = 0; i < conv; i++)
			{
				int indexer = int.Parse(input.ReadLine().Trim());
				data[indexer]++;
			}

			for (int i = 0; i < data.Length; i++) // 모든 가능한 값을 순회
			{
				while (data[i] > 0)
				{
					output.WriteLine(i);
					data[i]--;
				}
			}

			output.Close();
			input.Close();
		}
	}
}
