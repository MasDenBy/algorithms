using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
	public static class Shell
	{
		public static void Sort<T>(IList<T> values)
			where T : IComparable
		{
			if (values.Count == 1)
				return;

			int h = 1;
			while (h < values.Count / 3)
				h = 3 * h + 1;

			while (h >= 1)
			{
				for (int i = h; i < values.Count; i++)
				{
					for (int j = i; j >= h && values[j].LessThan(values[j-h]); j-=h)
					{
						values.Swap(j, j - h);
					}
				}

				h = h / 3;
			}
		}
	}
}