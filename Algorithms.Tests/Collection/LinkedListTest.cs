namespace AlgorithmsTest.Collection;

public class LinkedListTest
{
    [Fact]
    public void AddTest()
    {
        // Arrange
        var linkedList = new Algorithms.Collection.LinkedList<int>();

        // Act
        linkedList.AddFirst(2);
        linkedList.AddLast(3);
        linkedList.AddFirst(1);

        var numbers = string.Join(',', linkedList.GetElements());

        // Assert
        Assert.Equal("1,2,3", numbers);
    }

    [Fact]
    public void RemoveTest()
    {
        // Arrange
        var linkedList = new Algorithms.Collection.LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);

        // Act
        linkedList.RemoveFirst();
        linkedList.RemoveLast();

        var numbers = string.Join(',', linkedList.GetElements());

        // Assert
        Assert.Equal("2,3", numbers);
    }

    [Fact]
    public void AddFirstWithOneTest()
    {
        // Arrange
        var linkedList = new Algorithms.Collection.LinkedList<int>();
        linkedList.AddFirst(3);

        // Act & Assert
        Assert.Equal(3, linkedList.Head);
        Assert.Equal(3, linkedList.Tail);
    }

    [Fact]
    public void AddLastWithOneTest()
    {
        // Arrange
        var linkedList = new Algorithms.Collection.LinkedList<int>();
        linkedList.AddLast(3);

        // Act & Assert
        Assert.Equal(3, linkedList.Head);
        Assert.Equal(3, linkedList.Tail);
    }

    [Fact]
    public void AddFirstTest()
    {
        // Arrange
        var linkedList = new Algorithms.Collection.LinkedList<int>();

        // Act
        linkedList.AddFirst(1);
        linkedList.AddFirst(2);
        linkedList.AddFirst(3);

        // Assert
        Assert.Equal(3, linkedList.Head);
    }

    [Fact]
    public void AddLastTest()
    {
        // Arrange
        var linkedList = new Algorithms.Collection.LinkedList<int>();

        // Act
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        // Assert
        Assert.Equal(3, linkedList.Tail);
    }
}