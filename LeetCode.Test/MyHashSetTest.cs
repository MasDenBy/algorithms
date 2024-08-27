namespace LeetCode.Test
{
	public class MyHashSetTest
	{
		private MyHashSet hashSet;

		public MyHashSetTest()
		{
			this.hashSet = new MyHashSet();
		}

		[Fact]
		public void BaseTest()
		{
			// Act & Assert
			hashSet.Add(1);
			hashSet.Add(2);
			Assert.True(hashSet.Contains(1));    // returns true
			Assert.False(hashSet.Contains(3));    // returns false (not found)
			hashSet.Add(2);
			Assert.True(hashSet.Contains(2));    // returns true
			hashSet.Remove(2);
			Assert.False(hashSet.Contains(2));    // returns false (already removed)
		}
	}
}