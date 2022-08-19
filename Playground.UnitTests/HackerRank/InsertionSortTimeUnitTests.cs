using FluentAssertions;
using Playground.HackerRank;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class InsertionSortTimeUnitTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 0)]
        [InlineData(new[] { 1, 1, 2, 3 }, 0)]
        [InlineData(new[] { 1, 3, 2 }, 1)]
        [InlineData(new[] { 3, 2, 1 }, 3)]
        [InlineData(new[] { 5, 2, 4, 3, 1 }, 8)]
        [InlineData(new[] { 2, 1, 3, 1, 2 }, 4)]
        public void SortTime(int[] array, int expectedInsertions)
        {
            var result = InsertionSortTime.Sort(array);

            result.Should().Be(expectedInsertions);
        }
    }
}
