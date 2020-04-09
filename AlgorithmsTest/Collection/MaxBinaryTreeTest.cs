﻿using Algorithms.Collection;

using NUnit.Framework;

namespace AlgorithmsTest.Collection
{
	[TestFixture]
	public class MaxBinaryTreeTest
	{
		[Test]
		public void AddThreeItemsTest()
		{
			// Arrange
			var binaryTree = new MaxBinaryTree<int>(3);

			// Act
			binaryTree.Add(1);
			binaryTree.Add(2);
			binaryTree.Add(3);

			// Assert
			Assert.AreEqual(3, binaryTree.Max);
		}

		[Test]
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
			Assert.AreEqual(3, binaryTree.Max);
		}
	}
}