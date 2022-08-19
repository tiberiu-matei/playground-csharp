using FluentAssertions;
using Playground.LeetCode.Trees;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Playground.UnitTests.LeetCode.Trees
{
    public class BinaryTreeInorderTraversalUnitTests
    {
        [Theory]
        [ClassData(typeof(BinaryTreeInorderTraversalDataGenerator))]

        public void MaxBinaryTreeDepth(IList<int> expected, BinaryTreeNode root)
        {
            var result = BinaryTreeInorderTraversal.InorderTraversal(root);

            result.Should().BeEquivalentTo(expected);
        }
    }

    public class BinaryTreeInorderTraversalDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new List<int>(), null},
            new object[] { new List<int> { 2 }, new BinaryTreeNode(2)},
            new object[] { new List<int> { 2, 3 }, new BinaryTreeNode(2, null, new BinaryTreeNode(3))},
            new object[] { new List<int> { 5, 2, 15, 10, 3, 7 }, new BinaryTreeNode(2, new BinaryTreeNode(5), new BinaryTreeNode(3, new BinaryTreeNode(10, new BinaryTreeNode(15)), new BinaryTreeNode(7)))},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
