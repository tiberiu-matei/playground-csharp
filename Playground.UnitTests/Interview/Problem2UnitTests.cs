using FluentAssertions;
using Playground.Interview;
using System.Linq;
using Xunit;

namespace Playground.UnitTests.Interview
{
    public class Problem2UnitTests
    {
        [Theory]
        [InlineData(new[] { "code", "doce", "ecod", "framer", "frame" }, new[] { "code", "frame", "framer" })]
        public void Test(string[] input, string[] expected)
        {
            var result = Problem2.DoStuff(input.ToList());

            result.Should().BeEquivalentTo(expected.ToList());
        }
    }
}
