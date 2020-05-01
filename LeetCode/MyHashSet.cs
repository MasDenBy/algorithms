namespace LeetCode
{
	/// <summary>
	/// 705. Design HashSet
	/// </summary>
	public class MyHashSet
	{
		private const int MaxElements = 10000;
		private const int EmptyValue = -1;

		private readonly int[] keys;

		public MyHashSet()
		{
			this.keys = new int[MaxElements];

			for (int i = 0; i < MaxElements; i++)
				this.keys[i] = EmptyValue;
		}

		public void Add(int key)
		{
			int i;
			for (i = MyHashSet.GetHash(key); this.keys[i] != EmptyValue; i = MyHashSet.NextElement(i))
			{
				if (this.keys[i] == key)
					break;
			}

			this.keys[i] = key;
		}

		public void Remove(int key)
		{
			int rmi;
			for (rmi = MyHashSet.GetHash(key); keys[rmi] != EmptyValue; rmi = MyHashSet.NextElement(rmi))
			{
				if (this.keys[rmi] == key)
				{
					this.keys[rmi] = EmptyValue;
					break;
				}
			}

			for (int i = rmi + 1; this.keys[i] != EmptyValue; i = MyHashSet.NextElement(i))
			{
				if(MyHashSet.GetHash(this.keys[i]) <= rmi)
				{
					this.keys[rmi] = this.keys[i];
					this.keys[i] = EmptyValue;
					rmi = i;
				}
			}
		}

		public bool Contains(int key)
		{
			for (int i = MyHashSet.GetHash(key); keys[i] != EmptyValue; i = MyHashSet.NextElement(i))
			{
				if (this.keys[i] == key)
					return true;
			}

			return false;
		}

		private static int GetHash(int key) => key.GetHashCode() % MaxElements;
		private static int NextElement(int index) => (index + 1) % MaxElements;
	}
}