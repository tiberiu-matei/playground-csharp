using FluentAssertions;
using Playground.HackerRank;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class SockMatchUnitTests
    {
        [Theory]
        [InlineData(3, new[] { 1, 2, 3 }, 0)]
        [InlineData(3, new[] { 1, 2, 1 }, 1)]
        [InlineData(6, new[] { 1, 2, 3, 3, 2, 1 }, 3)]
        [InlineData(5, new[] { 1, 2, 3, 3, 2 }, 2)]
        [InlineData(5, new[] { 3, 2, 3, 3, 2 }, 2)]
        [InlineData(5, new[] { 4, 4, 4, 4, 4 }, 2)]
        public void MatchSocks(int n, int[] array, int expected)
        {
            var result = SockMatch.MatchSocks(n, array);

            result.Should().Be(expected);
        }
    }
}
