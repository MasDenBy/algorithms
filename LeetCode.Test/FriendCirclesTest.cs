namespace LeetCode.Test;

public class FriendCirclesTest
{
    [Fact]
    public void FindCircleNumTwoGroupTest()
    {
        // Arrange
        var m = new int[3][];
        m[0] = [1, 1, 0];
        m[1] = [1, 1, 0];
        m[2] = [0, 0, 1];

        // Act
        var count = new FriendCircles().FindCircleNum(m);

        // Assert
        count.Should().Be(2);
    }

    [Fact]
    public void FindCircleNumOneGroupTest()
    {
        // Arrange
        var m = new int[3][];
        m[0] = [1, 1, 0];
        m[1] = [1, 1, 1];
        m[2] = [0, 1, 1];

        // Act
        var count = new FriendCircles().FindCircleNum(m);

        // Assert
        count.Should().Be(1);
    }

    [Fact]
    public void FindCircleNumThreeGroupTest()
    {
        // Arrange
        var m = new int[3][];
        m[0] = [1, 0, 0];
        m[1] = [0, 1, 0];
        m[2] = [0, 0, 1];

        // Act
        var count = new FriendCircles().FindCircleNum(m);

        // Assert
        count.Should().Be(3);
    }

    [Fact]
    public void FindCircleNumOneGroupFourPeopleTest()
    {
        // Arrange
        var m = new int[4][];
        m[0] = [1, 0, 0, 1];
        m[1] = [0, 1, 1, 0];
        m[2] = [0, 1, 1, 1];
        m[3] = [1, 0, 1, 1];

        // Act
        var count = new FriendCircles().FindCircleNum(m);

        // Assert
        count.Should().Be(1);
    }
}
