using System.Text;
using Algorithms.Collection;
using NUnit.Framework;

namespace AlgorithmsTest.Collection
{
	[TestFixture]
	public class QueueTest
	{
		[Test]
		public void DequeueIfEmptyShouldReturnDefaultTest()
		{
			// Arrange
			var queue = new Queue<string>();

			// Act
			var result = queue.Dequeue();

			// Assert
			Assert.IsNull(result);
		}

		[Test]
		public void EnqueueShouldAddElementTest()
		{
			// Arrange
			const string test = "1";
			var queue = new Queue<string>();

			// Act
			queue.Enqueue(test);

			// Assert
			Assert.That(queue.Peek(), Is.EqualTo(test));
		}

		[Test]
		public void EnqueueAndDequeueTest()
		{
			// Arrange
			const string test = "1";
			var queue = new Queue<string>();

			// Act
			queue.Enqueue(test);
			var actual = queue.Dequeue();

			// Assert
			Assert.That(actual, Is.EqualTo(test));
			Assert.IsNull(queue.Peek());
		}

		[Test]
		public void EnqueueWithResizeTest()
		{
			// Arrange
			var queue = new Queue<string>();

			// Act
			queue.Enqueue("1");
			queue.Enqueue("2");
			queue.Dequeue();
			queue.Enqueue("3");
			queue.Enqueue("4");
			queue.Enqueue("5");
			queue.Dequeue();
			queue.Enqueue("6");

			var sb = new StringBuilder();
			string data = null;
			while ((data = queue.Dequeue()) != null)
				sb.Append(data);

			// Assert
			Assert.That(sb.ToString(), Is.EqualTo("3456"));
		}
	}
}