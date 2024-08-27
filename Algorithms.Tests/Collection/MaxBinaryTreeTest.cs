using Algorithms.Collection;

namespace AlgorithmsTest.Collection
{
	public class MaxBinaryTreeTest
	{
		[Fact]
		public void AddThreeItemsTest()
		{
			// Arrange
			var binaryTree = new MaxBinaryTree<int>(3);

			// Act
			binaryTree.Add(1);
			binaryTree.Add(2);
			binaryTree.Add(3);

			// Assert
			Assert.Equal(3, binaryTree.Max);
		}

		[Fact]
		public void AddFourItemsAndRemoveMaxTest()
		{
			// Arrange
			var binaryTree = new MaxBinaryTree<int>(4);

			// Act
			binaryTree.Add(1);
			binaryTree.Add(2);
			binaryTree.Add(4);
			binaryTree.Add(3);
			binaryTree.RemoveMax();

			// Assert
			Assert.Equal(3, binaryTree.Max);
		}
	}
}