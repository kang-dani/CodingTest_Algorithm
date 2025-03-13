using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class Node
	{
		public int Data;
		public Node Next;

		public Node(int data)
		{
			Data = data;
			Next = null;
		}
	}
	public class CircleLinkedList
	{
		static StringBuilder output = new StringBuilder();
		private Node tail;
		public int count = 0;

		public void Add(int data)
		{
			Node node = new Node(data);
			if (tail == null)
			{
				tail = node;
				tail.Next = tail;
			}
			else
			{
				node.Next = tail.Next;
				tail.Next = node;
				tail = node;
			}
			count++;
		}
		public string RemoveIndex(int index)
		{
			Node current = tail;
			output.Clear();
			output.Append("<");
			while (count > 0)
			{
				for (int i = 0; i < index - 1; i++)
				{
					current = current.Next;
				}
				Node toRemove = current.Next;
				output.Append(toRemove.Data);

				if (count == 1) tail = null;
				else
				{
					current.Next = toRemove.Next;
					if (toRemove == tail) tail = current;
				}
				count--;
				if (count > 0) output.Append(", ");
			}
			output.Append('>');
			return output.ToString();
		}
	}
	class Program
	{

		static void Main()
		{
			string[] input = Console.ReadLine().Split(' ');

			int n = int.Parse(input[0]);
			int k = int.Parse(input[1]);

			CircleLinkedList list = new CircleLinkedList();

			for (int i = 1; i <= n; i++)
			{
				//사람 앉히기
				list.Add(i);
			}
			Console.WriteLine(list.RemoveIndex(k));
		}
	}

}