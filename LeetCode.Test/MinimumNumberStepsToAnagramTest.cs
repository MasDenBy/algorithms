namespace LeetCode.Test
{
    public class MinimumNumberStepsToAnagramTest
	{
		[InlineData("bab", "aba", 1)]
		[InlineData("leetcode", "practice", 5)]
		[InlineData("anagram", "mangaar", 0)]
		[InlineData("xxyyzz", "xxyyzz", 0)]
		[InlineData("friend", "family", 4)]
		public void MinStepsTest(string s, string t, int expected)
		{
			// Arrange & Act
			var actual = new MinimumNumberStepsToAnagram().MinSteps(s, t);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}