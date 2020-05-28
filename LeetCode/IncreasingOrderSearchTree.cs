using System.Collections.Generic;
using LeetCode.Entities;

namespace LeetCode
{
	/// <summary>
	/// 897. Increasing Order Search Tree
	/// </summary>
	public class IncreasingOrderSearchTree
	{
		public TreeNode IncreasingBST(TreeNode root)
		{
			var queue = new Queue<int>();
			Inorder(root, queue);

			var bst = new BinarySearchTree();

			while (queue.Count > 0)
				bst.Put(queue.Dequeue());

			return bst.Root;
		}

		private void Inorder(TreeNode node, Queue<int> queue)
		{
			if (node == null) return;

			Inorder(node.left, queue);
			queue.Enqueue(node.val);
			Inorder(node.right, queue);
		}

		public class BinarySearchTree
		{
			public TreeNode Root { get; private set; }

			public void Put(int value)
			{
				this.Root = this.Put(this.Root, value);
			}

			private TreeNode Put(TreeNode node, int value)
			{
				if (node == null) return new TreeNode(value);

				var compResult = value.CompareTo(node.val);

				if (compResult < 0) node.left = Put(node.left, value);
				else if (compResult > 0) node.right = Put(node.right, value);
				else node.val = value;

				return node;
			}
		}
	}
}