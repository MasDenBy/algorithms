using System.Text;

namespace LeetCode
{
	/// <summary>
	/// 1309. Decrypt String from Alphabet to Integer Mapping
	/// </summary>
	public class StringToIntegerMapping
	{
		public string FreqAlphabets(string s)
		{
			var sb = new StringBuilder();

			for (int i = 0; i < s.Length; i++)
			{
				var possibleBig = i + 2;

				if(possibleBig < s.Length && s[possibleBig] == '#')
				{
					sb.Append(GetLetter($"{s[i]}{s[i + 1]}"));
					i = possibleBig;
				}
				else
				{
					sb.Append(GetLetter(s[i].ToString()));
				}
			}

			return sb.ToString();
		}

		private static string GetLetter(string value)
		{
			var index = int.Parse(value);

			return ((char)('a' + index - 1)).ToString();
		}
	}
}