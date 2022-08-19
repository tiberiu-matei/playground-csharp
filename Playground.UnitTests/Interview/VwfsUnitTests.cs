using FluentAssertions;
using Playground.Interview;
using Xunit;

namespace Playground.UnitTests.Interview
{
    public class VwfsUnitTests
    {
        [Theory]
        [InlineData("11 5 7 3 8 1 9", "1 3 5 7 8 9 11")]
        [InlineData("11", "11")]
        [InlineData("11abaew", "Error with sorting")]
        public void Test(string input, string expected)
        {
            var result = Vwfs.DoStuff(input);

            result.Should().Be(expected);
        }
    }
}
