using System;
using System.Collections.Generic;
using Algorithms.Extensions;

namespace Algorithms.Sorting
{
	public static class Heap
	{
		public static void Sort<T>(IList<T> values)
			where T : IComparable
		{
			if (values.Count == 1)
				return;

			int n = values.Count - 1;

			// Fix each triangle to have max binary heap
			for (int i = Parent(n); i >= 0; i--)
				Sink(values, i, n);

			// Move each max element to the end of the array and fix max binary heap
			while (n > 0)
			{
				values.Swap(0, n--);
				Sink(values, 0, n);
			}
		}

		private static void Sink<T>(IList<T> values, int root, int last)
			where T : IComparable
		{
			while (Left(root) <= last)
			{
				int left = Left(root);
				int right = 2 * root + 2;

				// if left element less than right element increaset left+1 to have 
				// comparation with biggest element
				if (left < last && values[left].LessThan(values[right]))
					left++;

				if (values[root].BiggerThan(values[left]))
					break;

				values.Swap(root, left);
				root = left;
			}
		}

		private static int Parent(int index) => index / 2 - 1;
		private static int Left(int root) => 2 * root + 1;
	}
}