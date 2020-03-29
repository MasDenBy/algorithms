using System.Collections.Generic;

namespace Algorithms.Collection
{
	public class LinkedList<T>
	{
		private Node<T> head;
		private Node<T> tail;

		public T Head => this.head == null ? default(T) : this.head.element;
		public T Tail => this.tail == null ? default(T) : this.tail.element;

		public void AddFirst(T value)
		{
			var node = new Node<T>(value);

			if (this.head == null)
			{
				this.head = node;
				this.tail = node;
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
				this.tail = node;
			}
			else
			{
				var lastNode = this.tail;
				lastNode.next = node;
				node.prev = lastNode;
				this.tail = node;
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
			var lastNode = this.tail;

			if(lastNode.prev != null)
			{
				lastNode.prev.next = null;
				this.tail = lastNode.prev;
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