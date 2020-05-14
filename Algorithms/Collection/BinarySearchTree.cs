using System;
using System.Collections.Generic;

namespace Algorithms.Collection
{
	public class BinarySearchTree<TKey, TValue>
		where TKey : IComparable
	{
		protected Node Root { get; set; }

		public IEnumerable<TKey> Keys
		{
			get
			{
				var keys = new List<TKey>();
				this.PutKeysInList(this.Root, keys);
				return keys;
			}
		}

		public virtual void Put(TKey key, TValue value)
		{
			this.Root = this.Put(this.Root, key, value);
		}

		public TValue Get(TKey key)
		{
			var x = this.Root;

			while (x != null)
			{
				var compResult = key.CompareTo(x.key);

				if (compResult < 0) x = x.left;
				else if (compResult > 0) x = x.right;
				else return x.value;
			}

			return default(TValue);
		}

		protected virtual Node Put(Node node, TKey key, TValue value)
		{
			if (node == null) return new Node(key, value);

			var compResult = key.CompareTo(node.key);

			if (compResult < 0) node.left = Put(node.left, key, value);
			else if (compResult > 0) node.right = Put(node.right, key, value);
			else node.value = value;

			return node;
		}

		private void PutKeysInList(Node node, ICollection<TKey> keys)
		{
			if (node == null) return;
			this.PutKeysInList(node.left, keys);
			keys.Add(node.key);
			this.PutKeysInList(node.right, keys);
		}

		public class Node
		{
			public TKey key;
			public TValue value;
			public Node left;
			public Node right;

			public Node(TKey key, TValue value)
			{
				this.key = key;
				this.value = value;
			}
		}
	}
}