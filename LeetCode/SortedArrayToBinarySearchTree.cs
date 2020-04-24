using LeetCode.Entities;

namespace LeetCode
{
	/// <summary>
	/// 108. Convert Sorted Array to Binary Search Tree
	/// </summary>
	public class SortedArrayToBinarySearchTree
	{
		public TreeNode SortedArrayToBST(int[] nums)
		{
			var bst = new BinarySearchTree();
			bst.BuildFromSortedArray(nums);

			return bst.Root;
		}

		public class BinarySearchTree
		{
			public TreeNode Root { get; private set; }

			public void BuildFromSortedArray(int[] nums)
			{
				this.Root = BuildNode(nums, 0, nums.Length - 1);
			}

			private TreeNode BuildNode(int[] nums, int start, int end)
			{
				if (start > end) return null;

				int middle = (start + end) / 2;

				var node = new TreeNode(nums[middle]);
				node.left = BuildNode(nums, start, middle - 1);
				node.right = BuildNode(nums, middle + 1, end);

				return node;
			}
		}
	}
}