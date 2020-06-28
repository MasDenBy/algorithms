using LeetCode.Entities;

namespace LeetCode
{
	/// <summary>
	/// 81. Search in Rotated Sorted Array II
	/// </summary>
	public class SearchRotatedSortedArray2
	{
		public bool Search(int[] nums, int target)
		{
			var bst = new BinarySearchTree();
			bst.Build(nums);

			return bst.Exists(target);
		}

		private class BinarySearchTree
		{
			private TreeNode root;

			public void Build(int[] nums)
			{
				for (int i = 0; i < nums.Length; i++)
					this.root = BuildNode(this.root, nums[i]);
			}

			public bool Exists(int number)
			{
				var x = this.root;

				while (x != null)
				{
					var compResult = number.CompareTo(x.val);

					if (compResult < 0) x = x.left;
					else if (compResult > 0) x = x.right;
					else return true;
				}

				return false;
			}

			private TreeNode BuildNode(TreeNode node, int value)
			{
				if (node == null) return new TreeNode(value);

				var compResult = value.CompareTo(node.val);

				if (compResult < 0) node.left = BuildNode(node.left, value);
				else if (compResult > 0) node.right = BuildNode(node.right, value);
				else node.val = value;

				return node;
			}
		}
	}
}