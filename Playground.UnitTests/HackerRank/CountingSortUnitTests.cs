using FluentAssertions;
using Playground.HackerRank;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class CountingSortUnitTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 1, 1 })]
        [InlineData(new[] { 0, 99, 51, 99 }, new[] { 0, 51, 99 }, new[] { 1, 1, 2 })]
        public void Sort(int[] input, int[] expectedPopulated, int[] expectedValues)
        {
            var result = CountingSort.Sort(input);

            var expected = new int[100];
            for (var i = 0; i < expectedPopulated.Length; i++)
            {
                expected[expectedPopulated[i]] = expectedValues[i];
            }

            result.Should().BeEquivalentTo(expected);
        }
    }
}
