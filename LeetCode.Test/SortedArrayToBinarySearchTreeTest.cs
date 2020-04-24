using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class SortedArrayToBinarySearchTreeTest
	{
		[TestCase(new[] { -10, -3, 0, 5, 9 }, new int[] { 0, -10, -3, 5, 9 })]
		public void SortedListToBSTTest(int[] values, int[] expected)
		{
			// Act
			var actualBstRoot = new SortedArrayToBinarySearchTree().SortedArrayToBST(values);

			// Assert
			var actual = actualBstRoot.Nodes().ToList();

			for (int i = 0; i < expected.Length; i++)
				Assert.AreEqual(expected[i], actual[i].val);
		}
	}
}