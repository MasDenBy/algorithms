namespace LeetCode
{
    /// <summary>
    /// 125. Valid Palindrome
    /// </summary>
	public class ValidPalindrome
	{
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;

            s = s.ToUpperInvariant();

            int startIndex = 0;
            int endIndex = s.Length - 1;

            while(startIndex <= endIndex)
            {
                if (!char.IsLetterOrDigit(s[startIndex]))
                {
                    startIndex++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[endIndex]))
                {
                    endIndex--;
                    continue;
                }

                if (s[startIndex] == s[endIndex])
                {
                    startIndex++;
                    endIndex--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}