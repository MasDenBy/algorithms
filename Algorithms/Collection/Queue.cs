namespace Algorithms.Collection
{
	public class Queue<T>
	{
		private T[] values;
		private int firstElementIndex;
		private int lastElementIndex;

		public Queue()
			:this(2)
		{ }

		public Queue(int capacity)
		{
			this.values = new T[capacity];
			this.firstElementIndex = 0;
			this.lastElementIndex = -1;
		}

		private bool IsEmpty
		{
			get { return this.lastElementIndex < 0; }
		}

		public T Dequeue()
		{
			if (this.IsEmpty)
				return default(T);

			var element = this.values[this.firstElementIndex];
			this.values[this.firstElementIndex] = default(T);
			this.firstElementIndex++;

			return element;
		}

		public void Enqueue(T value)
		{
			++this.lastElementIndex;

			if (this.values.Length == this.lastElementIndex)
				Resize(this.values.Length * 2);

			this.values[this.lastElementIndex] = value;
		}

		public T Peek()
		{
			return this.IsEmpty
				? default(T) 
				: this.values[this.firstElementIndex];
		}

		private void Resize(int capacity)
		{
			var copy = new T[capacity];
			var index = 0;

			for (int i = this.firstElementIndex; i < this.lastElementIndex; i++)
				copy[index++] = this.values[i];

			this.firstElementIndex = 0;
			this.lastElementIndex = index;
			this.values = copy;
		}
	}
}