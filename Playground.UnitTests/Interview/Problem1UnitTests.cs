using FluentAssertions;
using Playground.Interview;
using Xunit;

namespace Playground.UnitTests.Interview
{
    public class Problem1UnitTests
    {
        [Theory]
        [InlineData("01011", 3)]
        public void Test(string input, int expected)
        {
            var result = Problem1.DoStuff(input);

            result.Should().Be(expected);
        }
    }
}
