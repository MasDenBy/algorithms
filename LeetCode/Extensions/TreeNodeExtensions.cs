using System.Collections.Generic;
using LeetCode.Entities;

namespace LeetCode.Extensions
{
	public static class TreeNodeExtensions
	{
		public static IEnumerable<TreeNode> Nodes(this TreeNode node)
		{
			Queue<TreeNode> nodes = new Queue<TreeNode>();
			BuildNode(node, nodes);

			return nodes;
		}

		private static void BuildNode(TreeNode node, Queue<TreeNode> nodes)
		{
			if (node == null) return;

			nodes.Enqueue(node);

			BuildNode(node.left, nodes);
			BuildNode(node.right, nodes);
		}
	}
}