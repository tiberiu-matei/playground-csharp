using FluentAssertions;
using Playground.HackerRank;
using System.Linq;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class CountTripletsUnitTests
    {
        [Theory]
        [InlineData(new long[] { 1 }, 2, 0)]
        [InlineData(new long[] { 1, 8, 15 }, 2, 0)]
        [InlineData(new long[] { 1, 3, 8, 16, 32 }, 2, 1)]
        [InlineData(new long[] { 1, 4, 16, 64 }, 4, 2)]
        [InlineData(new long[] { 1, 3, 9, 9, 27, 81 }, 3, 6)]
        public void Test(long[] input, long r, long expected)
        {
            var result = CountTriplets.Count(input.ToList(), r);

            result.Should().Be(expected);
        }
    }
}
