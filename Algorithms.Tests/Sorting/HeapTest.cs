using Algorithms.Sorting;
using FluentAssertions;

namespace AlgorithmsTest.Sorting
{
	public class HeapTest
	{
		[Fact]
		public void SortIntTest()
		{
			// Arrange
			var values = new[] { 3, 7, 2, 5, 9, 12, 34, 5, 8 };

			// Act
			Heap.Sort(values);

			// Assert
			values.Should().BeEquivalentTo([ 2, 3, 5, 5, 7, 8, 9, 12, 34 ]);
		}

		[Fact]
		public void SortCharTest()
		{
			// Arrange
			var values = new[] { 's', 'o', 'r', 't', 'e', 'x', 'a', 'm', 'p', 'l', 'e' };

			// Act
			Heap.Sort(values);

			// Assert
			values.Should().BeEquivalentTo(['a', 'e', 'e', 'l', 'm', 'o', 'p', 'r', 's', 't', 'x']);
		}
	}
}