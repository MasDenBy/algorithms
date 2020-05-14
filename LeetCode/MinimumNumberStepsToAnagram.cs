using Algorithms.Collection;

namespace LeetCode
{
	/// <summary>
	/// 1347. Minimum Number of Steps to Make Two Strings Anagram
	/// </summary>
	public class MinimumNumberStepsToAnagram
	{
		public int MinSteps(string s, string t)
		{
			var scount = new BinarySearchTree();
			var tcount = new BinarySearchTree();

			for (int i = 0; i < s.Length; i++)
			{
				scount.Put(s[i], 1);
				tcount.Put(t[i], 1);
			}

			int steps = 0;

			foreach (var key in scount.Keys)
			{
				var diff = scount.Get(key) - tcount.Get(key);

				if (diff > 0) steps += diff;
			}

			return steps;
		}

		public class BinarySearchTree : BinarySearchTree<char, int>
		{
			protected override Node Put(Node node, char key, int value)
			{
				if (node == null) return new Node(key, value);

				var compResult = key.CompareTo(node.key);

				if (compResult < 0) node.left = Put(node.left, key, value);
				else if (compResult > 0) node.right = Put(node.right, key, value);
				else node.value += value;

				return node;
			}
		}
	}
}