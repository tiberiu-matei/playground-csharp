using FluentAssertions;
using Playground.HackerRank;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class ArrayLeftRotationUnitTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 5, 1, 2, 3, 4 })]
        public void TestRotate(int[] input, int rotations, int[] expected)
        {
            var result = ArrayLeftRotation.Rotate(input, rotations);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
