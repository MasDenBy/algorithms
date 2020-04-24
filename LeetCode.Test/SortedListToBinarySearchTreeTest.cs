using System.Linq;
using LeetCode.Entities;
using LeetCode.Extensions;
using NUnit.Framework;

using static LeetCode.SortedListToBinarySearchTree;

namespace LeetCode.Test
{
	[TestFixture]
	public class SortedListToBinarySearchTreeTest
	{
		[TestCase(new[] { -10, -3, 0, 5, 9 }, new object[] { 0, -10, 5, -3, 9 })]
		public void SortedListToBSTTest(int[] values, object[] expectedValues)
		{
			// Arrange
			var linkedList = new LinkedList(values);
			var expectedBst = new BinarySearchTree();

			foreach (var item in expectedValues)
				expectedBst.Add((int)item);

			// Act
			var actualBstRoot = new SortedListToBinarySearchTree().SortedListToBST(linkedList.Head);

			// Assert
			var actual = actualBstRoot.Nodes().ToList();
			var expected = expectedBst.Root.Nodes().ToList();

			for (int i = 0; i < expected.Count; i++)
				Assert.AreEqual(expected[i].val, actual[i].val);
		}

		private class LinkedList
		{
			public LinkedList(int[] values)
			{
				this.Head = new ListNode(values[0]);
				var previous = this.Head;

				for (int i = 1; i < values.Length; i++)
				{
					previous.next = new ListNode(values[i]);
					previous = previous.next;
				}
			}

			public ListNode Head { get; private set; }
		}
	}
}