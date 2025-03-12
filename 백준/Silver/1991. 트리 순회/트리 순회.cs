using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp2
{ 
	class Program
	{
		static Dictionary<char, (char left, char right)> tree = new Dictionary<char, (char left, char right)>();

		static void PreOrder(char node) //현재 노드 -> 왼쪽 노드 -> 오른쪽 노드
		{
			Console.Write(node);
			if (tree[node].left != '.')
				PreOrder(tree[node].left);
			if (tree[node].right != '.')
				PreOrder(tree[node].right);
		}
		static void InOrder(char node)  //왼쪽 노드 -> 현재 노드 -> 오른쪽 노드
		{
			if (tree[node].left != '.')
				InOrder(tree[node].left);
			Console.Write(node);
			if (tree[node].right != '.')
				InOrder(tree[node].right);
		}
		static void PostOrder(char node) //왼쪽 노드 -> 오른쪽 노드 -> 현재 노드
		{
			if (tree[node].left != '.')
				PostOrder(tree[node].left);
			if (tree[node].right != '.')
				PostOrder(tree[node].right);
			Console.Write(node);
		}
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			for(int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split();
				char parent = input[0][0];
				char left = input[1][0];
				char right = input[2][0];

				tree[parent] = (left, right);
			}
			PreOrder('A');
			Console.WriteLine();
			InOrder('A');
			Console.WriteLine();
			PostOrder('A');
			Console.WriteLine();
		}
	}
}
