using FluentAssertions;
using Playground.HackerRank;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class CountingSortFinalUnitTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 0, 99, 51, 99 }, new[] { 0, 51, 99, 99 })]
        [InlineData(new[] { 51, 99, 50, 98 }, new[] { 50, 51, 98, 99 })]
        public void Sort(int[] input, int[] expected)
        {
            var result = CountingSortFinal.Sort(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
