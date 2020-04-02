using Algorithms.Sorting;
using NUnit.Framework;

namespace AlgorithmsTest.Sorting
{
	[TestFixture]
	public class ShellTest
	{
		[TestCase(new[] { 0 }, new[] { 0 })]
		[TestCase(new[] { 0, 3, 2, 7, 10, 3, 3 }, new[] { 0, 2, 3, 3, 3, 7, 10 })]
		[TestCase(new[] { 0, 1, 2, 7, 10 }, new[] { 0, 1, 2, 7, 10 })]
		[TestCase(new[] { 10, 7, 2, 1, 0 }, new[] { 0, 1, 2, 7, 10 })]
		public void SortTest(int[] input, int[] expected)
		{
			// Arrange & Act
			Shell.Sort(input);

			// Assert
			CollectionAssert.AreEqual(expected, input);
		}
	}
}