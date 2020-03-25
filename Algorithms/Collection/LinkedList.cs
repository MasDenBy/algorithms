using System.Collections.Generic;

namespace Algorithms.Collection
{
	public class LinkedList<T>
	{
		private Node<T> head;

		public void AddFirst(T value)
		{
			var node = new Node<T>(value);

			if (this.head == null)
			{
				this.head = node;
			}
			else
			{
				this.head.prev = node;
				node.next = this.head;
				this.head = node;
			}
		}

		public void AddLast(T value)
		{
			var node = new Node<T>(value);

			if (this.head == null)
			{
				this.head = node;
			}
			else
			{
				var lastNode = GetLastNode();
				lastNode.next = node;
				node.prev = lastNode;
			}
		}

		public void RemoveFirst()
		{
			this.head = this.head.next != null
				? this.head.next
				: null;
		}

		public void RemoveLast()
		{
			var lastNode = this.GetLastNode();

			if(lastNode.prev != null)
			{
				lastNode.prev.next = null;
			}
			else
			{
				lastNode = null;
			}
		}

		public IEnumerable<T> GetElements()
		{
			var node = this.head;

			while (node != null)
			{
				yield return node.element;

				node = node.next;
			}
		}

		private Node<T> GetLastNode()
		{
			var node = this.head;

			while (node.next != null)
				node = node.next;

			return node;
		}

		private class Node<T>
		{
			public Node(T element)
			{
				this.element = element;
			}

			public T element;
			public Node<T> next;
			public Node<T> prev;
		}
	}
}