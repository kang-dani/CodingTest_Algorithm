using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			int condition = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();
			StringBuilder output = new StringBuilder();

			for (int i = 0; i < condition; i++)
			{
				string[] input = Console.ReadLine().Split(' ');
				switch (input[0])
				{
					case "1":   //push
						stack.Push(int.Parse(input[1]));
						break;
					case "2":   //pop
						output.Append(stack.Count > 0 ? stack.Pop().ToString() + "\n" : "-1\n");
						break;
					case "3":   //count
						output.Append(stack.Count.ToString() + "\n");
						break;
					case "4":   //empty
						output.Append(stack.Count == 0 ? "1\n" : "0\n");
						break;
					case "5":   //empty & front
						output.Append(stack.Count == 0 ? "-1\n" : stack.Peek().ToString() + "\n");
						break;
				}
			}
			Console.WriteLine(output.ToString());
		}
	}
}
