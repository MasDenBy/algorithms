using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
	public static class Quick
	{
		public static void Sort<T>(IList<T> values)
			where T : IComparable
		{
			if (values.Count == 1)
				return;

			Sort(values, 0, values.Count - 1);
		}

		private static void Sort<T>(IList<T> values, int low, int high)
			where T : IComparable
		{
			if (high <= low) return;

			int lt = low;
			int gt = high;
			int i = low;
			T v = values[low];

			while (i <= gt)
			{
				int compResult = values[i].CompareTo(v);
				if (compResult < 0) values.Swap(lt++, i++);
				else if (compResult > 0) values.Swap(i, gt--);
				else i++;
			}

			Sort(values, low, lt - 1);
			Sort(values, gt + 1, high);
		}
	}
}