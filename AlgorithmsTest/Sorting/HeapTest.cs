using Algorithms.Sorting;
using NUnit.Framework;

namespace AlgorithmsTest.Sorting
{
	[TestFixture]
	public class HeapTest
	{
		[Test]
		public void SortIntTest()
		{
			// Arrange
			var values = new[] { 3, 7, 2, 5, 9, 12, 34, 5, 8 };

			// Act
			Heap.Sort(values);

			// Assert
			CollectionAssert.AreEqual(new[] { 2, 3, 5, 5, 7, 8, 9, 12, 34 }, values);
		}

		[Test]
		public void SortCharTest()
		{
			// Arrange
			var values = new[] { 's', 'o', 'r', 't', 'e', 'x', 'a', 'm', 'p', 'l', 'e' };

			// Act
			Heap.Sort(values);

			// Assert
			CollectionAssert.AreEqual(new[] { 'a', 'e', 'e', 'l', 'm', 'o', 'p', 'r', 's', 't', 'x' }, values);
		}
	}
}