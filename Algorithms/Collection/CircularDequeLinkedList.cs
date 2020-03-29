namespace Algorithms.Collection
{
	public class CircularDequeLinkedList : ICircularDeque
	{
		private const int DataMissedCode = -1;

		private int capacity;
		private int count;

		private LinkedList<int> list;

		public CircularDequeLinkedList(int capacity)
		{
			this.capacity = capacity;
			this.count = 0;
			this.list = new LinkedList<int>();
		}

		public bool DeleteFront()
		{
			if (this.IsEmpty())
				return false;

			this.list.RemoveFirst();
			this.count--;
			return true;
		}

		public bool DeleteLast()
		{
			if (this.IsEmpty())
				return false;

			this.list.RemoveLast();
			this.count--;
			return true;
		}

		public int GetFront()
		{
			if (this.IsEmpty())
				return DataMissedCode;

			return this.list.Head;
		}

		public int GetRear()
		{
			if (this.IsEmpty())
				return DataMissedCode;

			return this.list.Tail;
		}

		public bool InsertFront(int value)
		{
			if (this.IsFull())
				return false;

			this.list.AddFirst(value);
			this.count++;
			return true;
		}

		public bool InsertLast(int value)
		{
			if (this.IsFull())
				return false;

			this.list.AddLast(value);
			this.count++;
			return true;
		}

		public bool IsEmpty()
		{
			return this.count == 0;
		}

		public bool IsFull()
		{
			return this.capacity == this.count;
		}
	}
}