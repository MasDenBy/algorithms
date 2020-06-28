using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class SearchRotatedSortedArray2Test
	{
		[TestCase(new[] { 2, 5, 6, 0, 0, 1, 2 }, 0, true)]
		[TestCase(new[] { 2, 5, 6, 0, 0, 1, 2 }, 3, false)]
		[TestCase(new[] { 3, 1 }, 1, true)]
		public void SearchTest(int[] nums, int target, bool expected)
		{
			Assert.AreEqual(expected, new SearchRotatedSortedArray2().Search(nums, target));
		}
	}
}