using Algorithms.Text;
using NUnit.Framework;

namespace AlgorithmsTest.Text
{
	[TestFixture]
	public class StringBuilderTest
	{
		[Test]
		public void AppendWithoutAllocationTest()
		{
			// Arrange
			var sb = new StringBuilder();

			// Act
			sb
				.Append("a")
				.Append("bc")
				.Append("  def ");

			var text = sb.ToString();

			// Assert
			Assert.AreEqual("abc  def ", text);
		}

		[Test]
		public void AppendWithAllocationTest()
		{
			// Arrange
			var sb = new StringBuilder(20);

			// Act
			sb
				.Append("Lorem ipsum dolor sit amet.")
				.Append(" Quisque tincidunt finibus enim, quis vehicula enim posuere et.")
				.Append(" Nam sagittis nibh a gravida consectetur.");

			var text = sb.ToString();

			// Assert
			Assert.AreEqual(
				"Lorem ipsum dolor sit amet. Quisque tincidunt finibus enim, quis vehicula enim posuere et. Nam sagittis nibh a gravida consectetur.", 
				text);
		}
	}
}