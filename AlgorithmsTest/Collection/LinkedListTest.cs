using Algorithms.Collection;

using NUnit.Framework;

namespace AlgorithmsTest.Collection
{
	[TestFixture]
	public class LinkedListTest
	{
		[Test]
		public void AddTest()
		{
			// Arrange
			var linkedList = new LinkedList<int>();

			// Act
			linkedList.AddFirst(2);
			linkedList.AddLast(3);
			linkedList.AddFirst(1);

			var numbers = string.Join(',', linkedList.GetElements());

			// Assert
			Assert.AreEqual("1,2,3", numbers);
		}

		[Test]
		public void RemoveTest()
		{
			// Arrange
			var linkedList = new LinkedList<int>();
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.AddLast(3);
			linkedList.AddLast(4);

			// Act
			linkedList.RemoveFirst();
			linkedList.RemoveLast();

			var numbers = string.Join(',', linkedList.GetElements());

			// Assert
			Assert.AreEqual("2,3", numbers);
		}

		[Test]
		public void AddFirstWithOneTest()
		{
			// Arrange
			var linkedList = new LinkedList<int>();
			linkedList.AddFirst(3);

			// Act & Assert
			Assert.AreEqual(3, linkedList.Head);
			Assert.AreEqual(3, linkedList.Tail);
		}

		[Test]
		public void AddLastWithOneTest()
		{
			// Arrange
			var linkedList = new LinkedList<int>();
			linkedList.AddLast(3);

			// Act & Assert
			Assert.AreEqual(3, linkedList.Head);
			Assert.AreEqual(3, linkedList.Tail);
		}

		[Test]
		public void AddFirstTest()
		{
			// Arrange
			var linkedList = new LinkedList<int>();

			// Act
			linkedList.AddFirst(1);
			linkedList.AddFirst(2);
			linkedList.AddFirst(3);

			// Assert
			Assert.AreEqual(3, linkedList.Head);
		}

		[Test]
		public void AddLastTest()
		{
			// Arrange
			var linkedList = new LinkedList<int>();

			// Act
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.AddLast(3);

			// Assert
			Assert.AreEqual(3, linkedList.Tail);
		}
	}
}