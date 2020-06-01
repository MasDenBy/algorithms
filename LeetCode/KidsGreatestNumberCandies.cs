using System.Collections.Generic;

namespace LeetCode
{
    /// <summary>
    /// 1431. Kids With the Greatest Number of Candies
    /// </summary>
	public class KidsGreatestNumberCandies
	{
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int[] kidWithExtra = new int[candies.Length];
            bool[] result = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
                kidWithExtra[i] = candies[i] + extraCandies;

            for (int i = 0; i < candies.Length; i++)
            {
                var greatest = true;
                for (int j = 0; j < candies.Length; j++)
                {
                    if (i == j) continue;
                    greatest = kidWithExtra[i] >= candies[j];
                    if (!greatest) break;
                }
                result[i] = greatest;
            }

            return result;
        }
    }
}