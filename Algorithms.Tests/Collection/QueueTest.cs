using System.Text;

namespace AlgorithmsTest.Collection
{
    public class QueueTest
	{
		[Fact]
		public void DequeueIfEmptyShouldReturnDefaultTest()
		{
			// Arrange
			var queue = new Algorithms.Collection.Queue<string>();

			// Act
			var result = queue.Dequeue();

			// Assert
			Assert.Null(result);
		}

		[Fact]
		public void EnqueueShouldAddElementTest()
		{
			// Arrange
			const string test = "1";
			var queue = new Algorithms.Collection.Queue<string>();

			// Act
			queue.Enqueue(test);

            // Assert
            queue.Peek().Should().Be(test);
		}

		[Fact]
		public void EnqueueAndDequeueTest()
		{
			// Arrange
			const string test = "1";
			var queue = new Algorithms.Collection.Queue<string>();

			// Act
			queue.Enqueue(test);
			var actual = queue.Dequeue();

			// Assert
			actual.Should().Be(test);
			Assert.Null(queue.Peek());
		}

		[Fact]
		public void EnqueueWithResizeTest()
		{
			// Arrange
			var queue = new Algorithms.Collection.Queue<string>();

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
			string? data = null;
			while ((data = queue.Dequeue()) != null)
				sb.Append(data);

			// Assert
			sb.ToString().Should().Be("3456");
		}
	}
}