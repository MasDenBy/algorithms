using System.Threading.Tasks;
using LeetCodeTestRunner;
using NUnit.Framework;

namespace LeetCode.Test
{
	[TestFixture]
	public class MyHashMapTest
	{
		[TestCase(@"[""MyHashMap"",""put"",""put"",""get"",""get"",""put"",""get"", ""remove"", ""get""]
[[],[1,1],[2,2],[1],[3],[2,1],[2],[2],[2]]",
			@"[null,null,null,1,-1,null,1,null,-1]")]
		[TestCase(@"[""MyHashMap"",""remove"",""get"",""put"",""put"",""put"",""get"",""put"",""put"",""put"",""put""]
[[],[14],[4],[7,3],[11,1],[12,1],[7],[1,19],[0,3],[1,8],[2,6]]", "")]
		public async Task Test(string input, string expected)
		{
			// Arrange
			var runner = new LeetCodeTestRunner<MyHashMap>();

			// Act
			await runner.Run(input, expected);
		}
	}
}