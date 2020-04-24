using System.Collections.Generic;
using LeetCode.Entities;

namespace LeetCode
{
	/// <summary>
	/// 109. Convert Sorted List to Binary Search Tree
	/// </summary>
	public class SortedListToBinarySearchTree
	{
		public TreeNode SortedListToBST(ListNode head)
		{
			var bst = new BinarySearchTree();
			bst.BuildFromSortedLinkedList(head);

			return bst.Root;
		}

		public class BinarySearchTree
		{
			public TreeNode Root { get; private set; }

			public void Add(int value)
			{
				this.Root = this.Add(value, this.Root);
			}

			public void BuildFromSortedLinkedList(ListNode node)
			{
				var values = ConvertToList(node);

				this.Root = BuildTree(values, 0, values.Count - 1);
			}

			public static IEnumerable<TreeNode> Nodes(TreeNode node)
			{
				Queue<TreeNode> nodes = new Queue<TreeNode>();
				Iteration(node, nodes);

				return nodes;
			}

			private static TreeNode BuildTree(List<int> values, int start, int end)
			{
				if (start > end) return null;

				int middle = (start + end) / 2;

				var node = new TreeNode(values[middle]);
				node.left = BuildTree(values, start, middle - 1);
				node.right = BuildTree(values, middle + 1, end);

				return node;
			}

			private static void Iteration(TreeNode node, Queue<TreeNode> nodes)
			{
				if (node == null) return;

				nodes.Enqueue(node);

				Iteration(node.left, nodes);
				Iteration(node.right, nodes);
			}

			private List<int> ConvertToList(ListNode head)
			{
				var result = new List<int>();
				var node = head;

				while (node != null)
				{
					result.Add(node.val);
					node = node.next;
				}

				return result;
			}

			private TreeNode Add(int value, TreeNode node)
			{
				if (node == null) return new TreeNode(value);

				var compResult = value.CompareTo(node.val);
				if (compResult < 0) node.left = Add(value, node.left);
				else if (compResult > 0) node.right = Add(value, node.right);
				else node.val = value;

				return node;
			}
		}
	}
}