using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// 785. Is Graph Bipartite?
	/// </summary>
	public class GraphBipartite
	{
		private bool?[] marked;

		public bool IsBipartite(int[][] graph)
		{
			var obj = new Graph(graph.Length);

			for (int i = 0; i < graph.Length; i++)
				for (int j = 0; j < graph[i].Length; j++)
					obj.AddEdge(i, graph[i][j]);

			this.marked = new bool?[obj.V];

			for (int i = 0; i < obj.V; i++)
			{
				if(!this.marked[i].HasValue)
				{
					if(!this.DepthFirstSearch(obj, i, true))
					{
						return false;
					}
				}
			}

			return true;
		}

		private bool DepthFirstSearch(Graph graph, int v, bool mark)
		{
			this.marked[v] = mark;
			var bipartite = true;

			foreach (var w in graph.Adjacents(v))
			{
				if (!this.marked[w].HasValue)
				{
					bipartite = this.DepthFirstSearch(graph, w, !mark);
				}

				if(!bipartite || this.marked[w] == mark)
				{
					return false;
				}
			}

			return bipartite;
		}

		private class Graph
		{
			private readonly HashSet<int>[] adjacents;

			public Graph(int v)
			{
				this.V = v;

				this.adjacents = new HashSet<int>[v];
				for (int i = 0; i < v; i++)
					this.adjacents[i] = new HashSet<int>();
			}

			public int V { get; private set; }

			public void AddEdge(int v, int w)
			{
				this.adjacents[v].Add(w);
				this.adjacents[w].Add(v);
			}

			public IEnumerable<int> Adjacents(int v) => this.adjacents[v];
		}
	}
}