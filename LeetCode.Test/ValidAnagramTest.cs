using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class ValidAnagramTest
	{
		[TestCase("anagram", "nagaram", true)]
		[TestCase("rat", "car", false)]
		public void IsAnagramTest(string s, string t, bool expected)
		{
			// Act
			Assert.AreEqual(expected, new ValidAnagram().IsAnagram(s, t));
		}
	}
}