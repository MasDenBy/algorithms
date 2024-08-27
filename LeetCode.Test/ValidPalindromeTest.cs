namespace LeetCode.Test
{
	public class ValidPalindromeTest
	{
		[InlineData("aa", true)]
		[InlineData("", true)]
		[InlineData("A man, a plan, a canal: Panama", true)]
		[InlineData("!!!::vrTTr::v!!!", true)]
		public void IsPalindromeTest(string s, bool expected)
		{
			Assert.Equal(expected, new ValidPalindrome().IsPalindrome(s));
		}
	}
}