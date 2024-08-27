namespace LeetCode.Test
{
	public class StringToIntegerMappingTest
	{
		[InlineData("10#11#12", "jkab")]
		[InlineData("1326#", "acz")]
		[InlineData("25#", "y")]
		[InlineData("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#", "abcdefghijklmnopqrstuvwxyz")]
		public void FreqAlphabetsTest(string s, string expected)
		{
			// Act & Arrange
			var result = new StringToIntegerMapping().FreqAlphabets(s);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}