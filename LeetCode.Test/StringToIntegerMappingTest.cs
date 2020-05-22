using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class StringToIntegerMappingTest
	{
		[TestCase("10#11#12", "jkab")]
		[TestCase("1326#", "acz")]
		[TestCase("25#", "y")]
		[TestCase("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#", "abcdefghijklmnopqrstuvwxyz")]
		public void FreqAlphabetsTest(string s, string expected)
		{
			// Act & Arrange
			var result = new StringToIntegerMapping().FreqAlphabets(s);

			// Assert
			Assert.AreEqual(expected, result);
		}
	}
}