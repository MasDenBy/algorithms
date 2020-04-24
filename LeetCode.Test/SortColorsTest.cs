using LeetCode;
using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class SortColorsTest
	{
		[TestCase(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
		[TestCase(new int[] { 2, 0, 2, 1, 1, 1, 0, 1 }, new int[] { 0, 0, 1, 1, 1, 1, 2, 2 })]
		public void SortTest(int[] input, int[] output)
		{
			// Arrange & Act
			new SortColors().Sort(input);

			// Arrange
			CollectionAssert.AreEqual(output, input);
		}
	}
}