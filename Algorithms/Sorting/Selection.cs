using System;
using System.Collections.Generic;
using Algorithms.Extensions;

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
					if (values[min].BiggerThan(values[j]))
						min = j;
				}

				values.Swap(i, min);
			}
		}
	}
}