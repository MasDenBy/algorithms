namespace Algorithms
{
	public class FriendCircles
	{
		public int FindCircleNum(int[][] array)
		{
			var uf = new UnionFind(array.Length);

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					if (array[i][j] == 1)
						uf.Union(i, j);
				}
			}

			return uf.Count;
		}

		private class UnionFind
		{
			int[] unions;
			int[] sizes;

			public UnionFind(int unionsCount)
			{
				this.unions = new int[unionsCount];
				this.sizes = new int[unionsCount];

				for (int i = 0; i < unionsCount; i++)
					this.unions[i] = i;
			}

			public int Count
			{
				get
				{
					int count = 0;
					int[] temp = new int[this.unions.Length];

					for (int i = 0; i < this.unions.Length; i++)
					{
						var root = GetRoot(i);
						if (temp[root] == 0)
							count++;

						temp[root]++;
					}

					return count;
				}
			}

			public void Union(int p, int q)
			{
				int i = GetRoot(p);
				int j = GetRoot(q);

				if (i == j)
					return;

				if(this.sizes[i] >= this.sizes[j])
				{
					this.unions[j] = i;
					this.sizes[i]++;
				} 
				else
				{
					this.unions[i] = j;
					this.sizes[j]++;
				}
			}

			private int GetRoot(int i)
			{
				while (i != this.unions[i])
					i = this.unions[i];

				return i;
			}
		}
	}
}