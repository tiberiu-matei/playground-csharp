using FluentAssertions;
using Playground.HackerRank;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class QuickSortSplitUnitTests
    {
        [Theory]
        [InlineData(new[] { 5, 7, 4, 3, 8 }, new[] { 4, 3, 5, 7, 8 })]
        [InlineData(new[] { 5, 7, 4, 5, 3, 8 }, new[] { 4, 3, 5, 5, 7, 8 })]
        public void QuickSortSplit_ProducesCorrectArray(int[] input, int[] expected)
        {
            var result = QuickSortSplit.Split(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
