using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	/// <summary>
	/// 1309. Decrypt String from Alphabet to Integer Mapping
	/// </summary>
	public class StringToIntegerMapping
	{
		private static readonly string[] alphabet = new string[] {
			"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
			"m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

		public string FreqAlphabets(string s)
		{
			var queue = new Queue<char>();
			var sb = new StringBuilder();

			for (int i = 0; i < s.Length; i++)
			{
				var value = s[i];

				if(value.Equals('#'))
				{
					ProcessQueue(queue, sb);
				}
				else
				{
					queue.Enqueue(value);
				}
			}

			if (queue.Count > 0)
			{
				if(s.EndsWith("#"))
				{
					ProcessQueue(queue, sb);
				}
				else
				{
					while (queue.Count > 0)
						sb.Append(GetLetter(queue.Dequeue().ToString()));
				}
			}

			return sb.ToString();
		}

		private static void ProcessQueue(Queue<char> queue, StringBuilder sb)
		{
			while (queue.Count > 2)
				sb.Append(GetLetter(queue.Dequeue().ToString()));

			sb.Append(GetLetter($"{queue.Dequeue()}{queue.Dequeue()}"));
		}

		private static string GetLetter(string value)
		{
			var index = int.Parse(value);
			return alphabet[index];
		}
	}
}