using Algorithms.Collection;

namespace AlgorithmsTest.Collection
{
	public class CircularDequeTest
	{
		[Theory]
		[InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void EmptyDequeTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.False(deque.DeleteFront());
			Assert.False(deque.DeleteLast());
			Assert.Equal(-1, deque.GetFront());
			Assert.Equal(-1, deque.GetRear());
			Assert.True(deque.IsEmpty());
			Assert.False(deque.IsFull());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void Test1(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.True(deque.InsertLast(1));
			Assert.True(deque.InsertLast(2));
			Assert.True(deque.InsertFront(3));
			Assert.False(deque.InsertFront(4));
			Assert.Equal(2, deque.GetRear());
			Assert.True(deque.IsFull());
			Assert.True(deque.DeleteLast());
			Assert.True(deque.InsertFront(4));
			Assert.Equal(4, deque.GetFront());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void Test2(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.True(deque.InsertFront(2));
			Assert.True(deque.InsertLast(4));
			Assert.True(deque.InsertFront(6));
			Assert.Equal(4, deque.GetRear());
			Assert.False(deque.InsertFront(5));
			Assert.Equal(6, deque.GetFront());
			Assert.Equal(6, deque.GetFront());
			Assert.False(deque.InsertFront(6));
			Assert.True(deque.IsFull());
			Assert.False(deque.InsertLast(6));
			Assert.Equal(4, deque.GetRear());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void Test3(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.True(deque.InsertFront(9));
			Assert.Equal(9, deque.GetRear());
			Assert.True(deque.InsertFront(9));
			Assert.Equal(9, deque.GetRear());
			Assert.True(deque.InsertLast(5));
			Assert.Equal(9, deque.GetFront());
			Assert.Equal(5, deque.GetRear());
			Assert.Equal(9, deque.GetFront());
			Assert.False(deque.InsertLast(8));
			Assert.True(deque.DeleteLast());
			Assert.Equal(9, deque.GetFront());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void Test4(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.True(deque.InsertFront(8));
			Assert.True(deque.InsertLast(8));
			Assert.True(deque.InsertLast(2));
			Assert.Equal(8, deque.GetFront());
			Assert.True(deque.DeleteLast());
			Assert.Equal(8, deque.GetRear());
			Assert.True(deque.InsertFront(9));
			Assert.True(deque.DeleteFront());
			Assert.Equal(8, deque.GetRear());
			Assert.True(deque.InsertLast(2));
			Assert.True(deque.IsFull());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void Test5(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 4);

			// Act & Assert
			Assert.True(deque.InsertFront(9));
			Assert.True(deque.DeleteLast());
			Assert.Equal(-1, deque.GetRear());
			Assert.Equal(-1, deque.GetFront());
			Assert.Equal(-1, deque.GetFront());
			Assert.False(deque.DeleteFront());
			Assert.True(deque.InsertFront(6));
			Assert.True(deque.InsertLast(5));
			Assert.True(deque.InsertFront(9));
			Assert.Equal(9, deque.GetFront());
			Assert.True(deque.InsertFront(6));
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void FrontPointTheSameElementAsRearTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 4);

			// Act & Assert
			Assert.True(deque.InsertLast(1));
			Assert.Equal(1, deque.GetFront());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void RearPointTheSameElementAsPointTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 4);

			// Act & Assert
			Assert.True(deque.InsertFront(1));
			Assert.Equal(1, deque.GetRear());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void FrontTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.True(deque.InsertFront(1));
			Assert.True(deque.InsertFront(2));
			Assert.Equal(2, deque.GetFront());
			Assert.True(deque.InsertFront(3));
			Assert.Equal(3, deque.GetFront());
			Assert.True(deque.IsFull());
			Assert.False(deque.InsertFront(4));
			Assert.True(deque.DeleteFront());
			Assert.False(deque.IsFull());
			Assert.True(deque.InsertFront(4));
			Assert.Equal(4, deque.GetFront());
			Assert.True(deque.DeleteFront());
			Assert.Equal(2, deque.GetFront());
			Assert.True(deque.DeleteFront());
			Assert.Equal(1, deque.GetFront());
			Assert.True(deque.DeleteFront());
			Assert.True(deque.IsEmpty());
		}

        [Theory]
        [InlineData(typeof(CircularDequeArray))]
		[InlineData(typeof(CircularDequeLinkedList))]
		public void RearTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.True(deque.InsertLast(1));
			Assert.True(deque.InsertLast(2));
			Assert.Equal(2, deque.GetRear());
			Assert.True(deque.InsertLast(3));
			Assert.Equal(3, deque.GetRear());
			Assert.True(deque.IsFull());
			Assert.False(deque.InsertLast(4));
			Assert.True(deque.DeleteLast());
			Assert.False(deque.IsFull());
			Assert.True(deque.InsertLast(4));
			Assert.Equal(4, deque.GetRear());
			Assert.True(deque.DeleteLast());
			Assert.Equal(2, deque.GetRear());
			Assert.True(deque.DeleteLast());
			Assert.Equal(1, deque.GetRear());
			Assert.True(deque.DeleteLast());
			Assert.True(deque.IsEmpty());
		}
	}
}