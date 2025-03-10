using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			int condition = int.Parse(Console.ReadLine());
			Queue<int> queue = new Queue<int>();
			StringBuilder output = new StringBuilder();
			int last = -1;

			for (int i = 0; i < condition; i++)
			{
				string[] input = Console.ReadLine().Split();

				switch (input[0])
				{
					case "push":
						last = int.Parse(input[1]);
						queue.Enqueue(last);
						break;
					case "pop":
						output.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "-1");
						break;
					case "size":
						output.AppendLine(queue.Count.ToString());
						break;
					case "empty":
						output.AppendLine(queue.Count == 0 ? "1" : "0");
						break;
					case "front":
						output.AppendLine(queue.Count > 0 ? queue.Peek().ToString() : "-1");
						break;
					case "back":
						output.AppendLine(queue.Count > 0 ? last.ToString() : "-1");
						break;
				}
			}

			Console.Write(output.ToString());
		}
	}
}
