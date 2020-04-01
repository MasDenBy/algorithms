using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
	public static class Selection
	{
		public static void Sort<T>(IList<T> values)
			where T : IComparable
		{
			int min;
			for (int i = 0; i < values.Count; i++)
			{
				min = i;

				for (int j = i + 1; j < values.Count; j++)
				{
					if (values[min].CompareTo(values[j]) > 0)
						min = j;
				}

				Swap(values, i, min);
			}
		}

		private static void Swap<T>(IList<T> values, int from, int to) 
			where T : IComparable
		{
			var temp = values[from];
			values[from] = values[to];
			values[to] = temp;
		}
	}
}