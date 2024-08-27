namespace LeetCode.Test;

public class SortColorsTest
{
    [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
    [InlineData(new int[] { 2, 0, 2, 1, 1, 1, 0, 1 }, new int[] { 0, 0, 1, 1, 1, 1, 2, 2 })]
    public void SortTest(int[] input, int[] output)
    {
        // Arrange & Act
        new SortColors().Sort(input);

        // Arrange
        input.Should().BeEquivalentTo(output);
    }
}