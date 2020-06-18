using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// 242. Valid Anagram
	/// </summary>
	public class ValidAnagram
	{
		public bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length) return false;

			var sMap = new Dictionary<char, int>();
			var tMap = new Dictionary<char, int>();

			for (int i = 0; i < s.Length; i++)
			{
				AddLetter(sMap, s[i]);
				AddLetter(tMap, t[i]);
			}

			foreach (var map in sMap)
			{
				if (!tMap.ContainsKey(map.Key) || tMap[map.Key] != map.Value)
					return false;
			}

			return true;
		}

		private static void AddLetter(Dictionary<char, int> dict, char letter)
		{
			dict[letter] = dict.ContainsKey(letter) ? dict[letter] + 1 : 1;
		}
	}
}