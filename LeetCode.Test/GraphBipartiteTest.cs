using LeetCodeTestRunner;

namespace LeetCode.Test;

public class GraphBipartiteTest
{
    [InlineData("[[1,3],[0,2],[1,3],[0,2]]", true)]
    [InlineData("[[1,2,3], [0,2], [0,1,3], [0,2]]", false)]
    [InlineData("[[],[2,4,6],[1,4,8,9],[7,8],[1,2,8,9],[6,9],[1,5,7,8,9],[3,6,9],[2,3,4,6,9],[2,4,5,6,7,8]]", false)]
    [InlineData("[[3,4,6],[3,6],[3,6],[0,1,2,5],[0,7,8],[3],[0,1,2,7],[4,6],[4],[]]", true)]
    public void Test(string input, bool expected)
    {
        // Arrange
        var leetCodeRunner = new LeetCodeTestRunner<GraphBipartite>();

        // Act
        var actual = leetCodeRunner.Run<int[][]>(input, (o, p) => o.IsBipartite(p));

        // Assert
        actual.Should().Be(expected);
    }
}
