using LeetCode;
using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class FriendCirclesTest
	{
		[Test]
		public void FindCircleNumTwoGroupTest()
		{
			// Arrange
			var m = new int[3][];
			m[0] = new int[3] { 1, 1, 0 };
			m[1] = new int[3] { 1, 1, 0 };
			m[2] = new int[3] { 0, 0, 1 };

			// Act
			var count = new FriendCircles().FindCircleNum(m);

			// Assert
			Assert.AreEqual(2, count);
		}

		[Test]
		public void FindCircleNumOneGroupTest()
		{
			// Arrange
			var m = new int[3][];
			m[0] = new int[3] { 1, 1, 0 };
			m[1] = new int[3] { 1, 1, 1 };
			m[2] = new int[3] { 0, 1, 1 };

			// Act
			var count = new FriendCircles().FindCircleNum(m);

			// Assert
			Assert.AreEqual(1, count);
		}

		[Test]
		public void FindCircleNumThreeGroupTest()
		{
			// Arrange
			var m = new int[3][];
			m[0] = new int[3] { 1, 0, 0 };
			m[1] = new int[3] { 0, 1, 0 };
			m[2] = new int[3] { 0, 0, 1 };

			// Act
			var count = new FriendCircles().FindCircleNum(m);

			// Assert
			Assert.AreEqual(3, count);
		}

		[Test]
		public void FindCircleNumOneGroupFourPeopleTest()
		{
			// Arrange
			var m = new int[4][];
			m[0] = new int[4] { 1, 0, 0, 1 };
			m[1] = new int[4] { 0, 1, 1, 0 };
			m[2] = new int[4] { 0, 1, 1, 1 };
			m[3] = new int[4] { 1, 0, 1, 1 };

			// Act
			var count = new FriendCircles().FindCircleNum(m);

			// Assert
			Assert.AreEqual(1, count);
		}
	}
}