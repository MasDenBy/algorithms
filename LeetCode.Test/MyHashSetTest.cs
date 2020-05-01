using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class MyHashSetTest
	{
		private MyHashSet hashSet;

		[SetUp]
		public void Setup()
		{
			this.hashSet = new MyHashSet();
		}

		[Test]
		public void BaseTest()
		{
			// Act & Assert
			hashSet.Add(1);
			hashSet.Add(2);
			Assert.IsTrue(hashSet.Contains(1));    // returns true
			Assert.IsFalse(hashSet.Contains(3));    // returns false (not found)
			hashSet.Add(2);
			Assert.IsTrue(hashSet.Contains(2));    // returns true
			hashSet.Remove(2);
			Assert.IsFalse(hashSet.Contains(2));    // returns false (already removed)
		}
	}
}