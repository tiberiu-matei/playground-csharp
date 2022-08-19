using FluentAssertions;
using Playground.LeetCode.Trees;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Playground.UnitTests.LeetCode.Trees
{
    public class BinaryTreeMaxDepthUnitTests
    {
        [Theory]
        [ClassData(typeof(BinaryTreeMaxDepthDataGenerator))]

        public void MaxBinaryTreeDepth(int expectedDepth, BinaryTreeNode root)
        {
            var result = BinaryTreeMaxDepth.MaxDepth(root);

            result.Should().Be(expectedDepth);
        }
    }

    public class BinaryTreeMaxDepthDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {0, null},
            new object[] {1, new BinaryTreeNode(2)},
            new object[] {2, new BinaryTreeNode(2, null, new BinaryTreeNode(3))},
            new object[] {3, new BinaryTreeNode(2, new BinaryTreeNode(5), new BinaryTreeNode(3, new BinaryTreeNode(10), new BinaryTreeNode(7)))},
            new object[] {4, new BinaryTreeNode(2, new BinaryTreeNode(5, null, new BinaryTreeNode(13)), new BinaryTreeNode(3, new BinaryTreeNode(10, null, new BinaryTreeNode(65)), null))},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
