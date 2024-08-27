using LeetCode.Extensions;

namespace LeetCode.Test
{
    public class SortedArrayToBinarySearchTreeTest
	{
		[InlineData(new[] { -10, -3, 0, 5, 9 }, new int[] { 0, -10, -3, 5, 9 })]
		public void SortedListToBSTTest(int[] values, int[] expected)
		{
			// Act
			var actualBstRoot = new SortedArrayToBinarySearchTree().SortedArrayToBST(values);

			// Assert
			var actual = actualBstRoot.Nodes().ToList();

			for (int i = 0; i < expected.Length; i++)
				Assert.Equal(expected[i], actual[i].val);
		}
	}
}