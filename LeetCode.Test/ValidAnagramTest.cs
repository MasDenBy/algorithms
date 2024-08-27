namespace LeetCode.Test
{
	public class ValidAnagramTest
	{
		[InlineData("anagram", "nagaram", true)]
		[InlineData("rat", "car", false)]
		public void IsAnagramTest(string s, string t, bool expected)
		{
			// Act
			Assert.Equal(expected, new ValidAnagram().IsAnagram(s, t));
		}
	}
}