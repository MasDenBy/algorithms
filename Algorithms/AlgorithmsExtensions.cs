using System;
using System.Collections.Generic;

namespace Algorithms
{
	public static class AlgorithmsExtensions
	{
		public static bool BiggerThan(this IComparable value1, IComparable value2)
		{
			return value1.CompareTo(value2) > 0;
		}

		public static bool LessThan(this IComparable value1, IComparable value2)
		{
			return value1.CompareTo(value2) < 0;
		}

		public static void Swap<T>(this IList<T> values, int from, int to)
			where T : IComparable
		{
			var temp = values[from];
			values[from] = values[to];
			values[to] = temp;
		}
	}
}