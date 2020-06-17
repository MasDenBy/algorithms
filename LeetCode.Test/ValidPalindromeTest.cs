using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class ValidPalindromeTest
	{
		[TestCase("aa", true)]
		[TestCase("", true)]
		[TestCase("A man, a plan, a canal: Panama", true)]
		[TestCase("!!!::vrTTr::v!!!", true)]
		public void IsPalindromeTest(string s, bool expected)
		{
			Assert.AreEqual(expected, new ValidPalindrome().IsPalindrome(s));
		}
	}
}