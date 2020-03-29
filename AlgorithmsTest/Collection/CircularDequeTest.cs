using System;
using Algorithms.Collection;
using NUnit.Framework;

namespace AlgorithmsTest.Collection
{
	[TestFixture]
	public class CircularDequeTest
	{
		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void EmptyDequeTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsFalse(deque.DeleteFront());
			Assert.IsFalse(deque.DeleteLast());
			Assert.AreEqual(-1, deque.GetFront());
			Assert.AreEqual(-1, deque.GetRear());
			Assert.IsTrue(deque.IsEmpty());
			Assert.IsFalse(deque.IsFull());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void Test1(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsTrue(deque.InsertLast(1));
			Assert.IsTrue(deque.InsertLast(2));
			Assert.IsTrue(deque.InsertFront(3));
			Assert.IsFalse(deque.InsertFront(4));
			Assert.AreEqual(2, deque.GetRear());
			Assert.IsTrue(deque.IsFull());
			Assert.IsTrue(deque.DeleteLast());
			Assert.IsTrue(deque.InsertFront(4));
			Assert.AreEqual(4, deque.GetFront());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void Test2(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsTrue(deque.InsertFront(2));
			Assert.IsTrue(deque.InsertLast(4));
			Assert.IsTrue(deque.InsertFront(6));
			Assert.AreEqual(4, deque.GetRear());
			Assert.IsFalse(deque.InsertFront(5));
			Assert.AreEqual(6, deque.GetFront());
			Assert.AreEqual(6, deque.GetFront());
			Assert.IsFalse(deque.InsertFront(6));
			Assert.IsTrue(deque.IsFull());
			Assert.IsFalse(deque.InsertLast(6));
			Assert.AreEqual(4, deque.GetRear());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void Test3(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsTrue(deque.InsertFront(9));
			Assert.AreEqual(9, deque.GetRear());
			Assert.IsTrue(deque.InsertFront(9));
			Assert.AreEqual(9, deque.GetRear());
			Assert.IsTrue(deque.InsertLast(5));
			Assert.AreEqual(9, deque.GetFront());
			Assert.AreEqual(5, deque.GetRear());
			Assert.AreEqual(9, deque.GetFront());
			Assert.IsFalse(deque.InsertLast(8));
			Assert.IsTrue(deque.DeleteLast());
			Assert.AreEqual(9, deque.GetFront());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void Test4(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsTrue(deque.InsertFront(8));
			Assert.IsTrue(deque.InsertLast(8));
			Assert.IsTrue(deque.InsertLast(2));
			Assert.AreEqual(8, deque.GetFront());
			Assert.IsTrue(deque.DeleteLast());
			Assert.AreEqual(8, deque.GetRear());
			Assert.IsTrue(deque.InsertFront(9));
			Assert.IsTrue(deque.DeleteFront());
			Assert.AreEqual(8, deque.GetRear());
			Assert.IsTrue(deque.InsertLast(2));
			Assert.IsTrue(deque.IsFull());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void Test5(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 4);

			// Act & Assert
			Assert.IsTrue(deque.InsertFront(9));
			Assert.IsTrue(deque.DeleteLast());
			Assert.AreEqual(-1, deque.GetRear());
			Assert.AreEqual(-1, deque.GetFront());
			Assert.AreEqual(-1, deque.GetFront());
			Assert.IsFalse(deque.DeleteFront());
			Assert.IsTrue(deque.InsertFront(6));
			Assert.IsTrue(deque.InsertLast(5));
			Assert.IsTrue(deque.InsertFront(9));
			Assert.AreEqual(9, deque.GetFront());
			Assert.IsTrue(deque.InsertFront(6));
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void FrontPointTheSameElementAsRearTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 4);

			// Act & Assert
			Assert.IsTrue(deque.InsertLast(1));
			Assert.AreEqual(1, deque.GetFront());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void RearPointTheSameElementAsPointTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 4);

			// Act & Assert
			Assert.IsTrue(deque.InsertFront(1));
			Assert.AreEqual(1, deque.GetRear());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void FrontTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsTrue(deque.InsertFront(1));
			Assert.IsTrue(deque.InsertFront(2));
			Assert.AreEqual(2, deque.GetFront());
			Assert.IsTrue(deque.InsertFront(3));
			Assert.AreEqual(3, deque.GetFront());
			Assert.IsTrue(deque.IsFull());
			Assert.IsFalse(deque.InsertFront(4));
			Assert.IsTrue(deque.DeleteFront());
			Assert.IsFalse(deque.IsFull());
			Assert.IsTrue(deque.InsertFront(4));
			Assert.AreEqual(4, deque.GetFront());
			Assert.IsTrue(deque.DeleteFront());
			Assert.AreEqual(2, deque.GetFront());
			Assert.IsTrue(deque.DeleteFront());
			Assert.AreEqual(1, deque.GetFront());
			Assert.IsTrue(deque.DeleteFront());
			Assert.IsTrue(deque.IsEmpty());
		}

		[TestCase(typeof(CircularDequeArray))]
		[TestCase(typeof(CircularDequeLinkedList))]
		public void RearTest(Type circularDequeType)
		{
			// Arrange
			var deque = (ICircularDeque)Activator.CreateInstance(circularDequeType, 3);

			// Act & Assert
			Assert.IsTrue(deque.InsertLast(1));
			Assert.IsTrue(deque.InsertLast(2));
			Assert.AreEqual(2, deque.GetRear());
			Assert.IsTrue(deque.InsertLast(3));
			Assert.AreEqual(3, deque.GetRear());
			Assert.IsTrue(deque.IsFull());
			Assert.IsFalse(deque.InsertLast(4));
			Assert.IsTrue(deque.DeleteLast());
			Assert.IsFalse(deque.IsFull());
			Assert.IsTrue(deque.InsertLast(4));
			Assert.AreEqual(4, deque.GetRear());
			Assert.IsTrue(deque.DeleteLast());
			Assert.AreEqual(2, deque.GetRear());
			Assert.IsTrue(deque.DeleteLast());
			Assert.AreEqual(1, deque.GetRear());
			Assert.IsTrue(deque.DeleteLast());
			Assert.IsTrue(deque.IsEmpty());
		}
	}
}