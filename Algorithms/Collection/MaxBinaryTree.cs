using System;

namespace Algorithms.Collection
{
	public class MaxBinaryTree<T>
		where T : IComparable
	{
		private int count;
		private T[] values;

		public MaxBinaryTree(int capacity)
		{
			this.count = 0;
			this.values = new T[capacity];
		}

		public T Max => this.values[0];

		public void Add(T value)
		{
			int currentIndex = this.count;

			this.values[currentIndex] = value;
			this.count++;

			while(currentIndex > 0 && this.values[currentIndex].BiggerThan(this.values[ParentIndex(currentIndex)]))
			{
				this.values.Swap(currentIndex, ParentIndex(currentIndex));
				currentIndex = ParentIndex(currentIndex);
			}
		}

		public void RemoveMax()
		{
			this.values.Swap(0, --this.count);

			int currentIndex = 0;

			while (currentIndex < this.count - 1 &&
				this.values[currentIndex].LessThan(MaxDescendant(currentIndex, out var descendantIndex)))
			{
				this.values.Swap(currentIndex, descendantIndex);
				currentIndex = descendantIndex;
			}
		}

		private T MaxDescendant(int currentIndex, out int descendantIndex)
		{
			int leftDescendant = LeftDescendantIndex(currentIndex);
			int rightDescendant = RightDescendantIndex(currentIndex);
			int lastIndex = this.count - 1;

			if (leftDescendant > lastIndex && rightDescendant > lastIndex)
				descendantIndex = currentIndex;
			else if (leftDescendant < lastIndex && rightDescendant > lastIndex)
				descendantIndex = leftDescendant;
			else if (leftDescendant > this.count && rightDescendant < lastIndex)
				descendantIndex = rightDescendant;
			else 
				descendantIndex = this.values[leftDescendant].BiggerThan(this.values[rightDescendant]) 
					? leftDescendant 
					: rightDescendant;

			return this.values[descendantIndex];
		}

		private static int ParentIndex(int child) => (child - 1) / 2;
		private static int LeftDescendantIndex(int parentIndex) => 2 * parentIndex + 1;
		private static int RightDescendantIndex(int parentIndex) => 2 * parentIndex + 2;
	}
}