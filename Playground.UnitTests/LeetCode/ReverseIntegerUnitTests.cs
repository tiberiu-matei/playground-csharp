using FluentAssertions;
using Playground.LeetCode;
using Xunit;

namespace Playground.UnitTests.LeetCode
{
    public class ReverseIntegerUnitTests
    {
        private readonly ReverseInteger service = new ReverseInteger();

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(-1, -1)]
        [InlineData(-105, -501)]
        [InlineData(-134, -431)]
        [InlineData(1000, 1)]
        [InlineData(123, 321)]
        [InlineData(111, 111)]
        [InlineData(103, 301)]
        [InlineData(2147483599, 0)]
        [InlineData(-2147483599, 0)]
        public void GivenValidTarget_GetSumIndices_ShouldReturnCorrectValues(int input, int expected)
        {
            var result = this.service.Reverse(input);

            result.Should().Be(expected);
        }
    }
}
