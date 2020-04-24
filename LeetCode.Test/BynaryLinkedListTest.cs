using System.Collections.Generic;
using LeetCode;
using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class BynaryLinkedListTest
	{
		[Test]
		public void Test1()
		{
			// Arrange
			var linkedList = new LinkedList<byte>();
			linkedList.AddLast(1);
			linkedList.AddLast(0);
			linkedList.AddLast(1);

			// Act & Assert
			GetDecimalValueTest(linkedList, 5);
		}

		[Test]
		public void Test2()
		{
			// Arrange
			var linkedList = new LinkedList<byte>();
			linkedList.AddLast(0);

			// Act & Assert
			GetDecimalValueTest(linkedList, 0);
		}

		[Test]
		public void Test3()
		{
			// Arrange
			var linkedList = new LinkedList<byte>();
			linkedList.AddLast(1);

			// Act & Assert
			GetDecimalValueTest(linkedList, 1);
		}

		[Test]
		public void Test4()
		{
			// Arrange
			var linkedList = new LinkedList<byte>();
			linkedList.AddLast(1);
			linkedList.AddLast(0);
			linkedList.AddLast(0);
			linkedList.AddLast(1);
			linkedList.AddLast(0);
			linkedList.AddLast(0);
			linkedList.AddLast(1);
			linkedList.AddLast(1);
			linkedList.AddLast(1);
			linkedList.AddLast(0);
			linkedList.AddLast(0);
			linkedList.AddLast(0);
			linkedList.AddLast(0);
			linkedList.AddLast(0);
			linkedList.AddLast(0);

			// Act & Assert
			GetDecimalValueTest(linkedList, 18880);
		}

		[Test]
		public void Test5()
		{
			// Arrange
			var linkedList = new LinkedList<byte>();
			linkedList.AddLast(0);
			linkedList.AddLast(0);

			// Act & Assert
			GetDecimalValueTest(linkedList, 0);
		}

		private static void GetDecimalValueTest(LinkedList<byte> linkedList, int expected)
		{
			// Act
			var number = new BynaryLinkedList().GetDecimalValue(linkedList.First);

			// Assert
			Assert.That(number, Is.EqualTo(expected));
		}
	}
}