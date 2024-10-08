﻿using Algorithms.Sorting;

namespace AlgorithmsTest.Sorting
{
	public class QuickTest
	{
        [Theory]
        [InlineData(new[] { 0 }, new[] { 0 })]
		[InlineData(new[] { 0, 3, 2, 7, 10, 3, 3 }, new[] { 0, 2, 3, 3, 3, 7, 10 })]
		[InlineData(new[] { 0, 1, 2, 7, 10 }, new[] { 0, 1, 2, 7, 10 })]
		[InlineData(new[] { 10, 7, 2, 1, 0 }, new[] { 0, 1, 2, 7, 10 })]
		public void SortTest(int[] input, int[] expected)
		{
			// Arrange & Act
			Quick.Sort(input);

			// Assert
			input.Should().BeEquivalentTo(expected);
		}
	}
}