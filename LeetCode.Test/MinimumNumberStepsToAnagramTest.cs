using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class MinimumNumberStepsToAnagramTest
	{
		[TestCase("bab", "aba", 1)]
		[TestCase("leetcode", "practice", 5)]
		[TestCase("anagram", "mangaar", 0)]
		[TestCase("xxyyzz", "xxyyzz", 0)]
		[TestCase("friend", "family", 4)]
		public void MinStepsTest(string s, string t, int expected)
		{
			// Arrange & Act
			var actual = new MinimumNumberStepsToAnagram().MinSteps(s, t);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}