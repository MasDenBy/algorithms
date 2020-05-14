using System;
using System.Collections.Generic;
using Algorithms.Extensions;

namespace Algorithms.Sorting
{
	public static class Insertion
	{
		public static void Sort<T>(IList<T> values)
			where T : IComparable
		{
			if (values.Count == 1)
				return;

			for (int i = 0; i < values.Count; i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (values[j].LessThan(values[j - 1]))
						values.Swap(j, j - 1);
					else
						break;
				}
			}
		}
	}
}