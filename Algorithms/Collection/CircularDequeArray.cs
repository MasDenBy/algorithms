namespace Algorithms.Collection
{
	public class CircularDequeArray : ICircularDeque
	{
		private const int DataMissedCode = -1;

		private int[] values;

		private int frontIndex;
		private int lastIndex;

		private int count;

		public CircularDequeArray(int capacity)
		{
			this.values = new int[capacity];
			this.frontIndex = -1;
			this.lastIndex = -1;
			this.count = 0;
		}

		public bool InsertFront(int value)
		{
			if (this.IsFull())
				return false;

			if(!InsertIntoEmptyDeque(value))
			{
				this.frontIndex = this.frontIndex == this.values.Length - 1
					? 0
					: this.frontIndex + 1;

				this.values[this.frontIndex] = value;
			}

			this.count++;

			return true;
		}

		public bool InsertLast(int value)
		{
			if (this.IsFull())
				return false;

			if (!InsertIntoEmptyDeque(value))
			{
				this.lastIndex = this.lastIndex == 0 
					? this.values.Length - 1 
					: this.lastIndex - 1;

				this.values[this.lastIndex] = value;
			}

			this.count++;

			return true;
		}

		public bool DeleteFront()
		{
			if (this.IsEmpty())
				return false;

			this.frontIndex = this.frontIndex == 0
				? this.values.Length - 1
				: this.frontIndex - 1;

			this.count--;

			return true;
		}

		public bool DeleteLast()
		{
			if (this.IsEmpty())
				return false;

			this.lastIndex = this.lastIndex == this.values.Length - 1 
				? 0 
				: this.lastIndex + 1;

			this.count--;

			return true;
		}

		public int GetFront()
		{
			if (this.IsEmpty())
				return DataMissedCode;

			return this.values[this.frontIndex];
		}

		public int GetRear()
		{
			if (this.IsEmpty())
				return DataMissedCode;

			return this.values[this.lastIndex];
		}

		public bool IsEmpty()
		{
			return this.count == 0;
		}

		public bool IsFull()
		{
			return this.count == this.values.Length;
		}

		private bool InsertIntoEmptyDeque(int value)
		{
			if (this.IsEmpty())
			{
				this.frontIndex = this.lastIndex = 0;
				this.values[0] = value;

				return true;
			}

			return false;
		}
	}
}