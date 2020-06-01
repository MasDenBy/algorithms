using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class KidsGreatestNumberCandiesTest
	{
		[TestCase(new int[] { 2, 3, 5, 1, 3 }, 3, new bool[] { true, true, true, false, true })]
		public void KidsWithCandiesTest(int[] candies, int extraCandies, bool[] expected)
		{
			// Arrange & Act
			var actual = new KidsGreatestNumberCandies().KidsWithCandies(candies, extraCandies);

			// Assert
			for (int i = 0; i < expected.Length; i++)
				Assert.AreEqual(actual[i], expected[i]);
		}
	}
}