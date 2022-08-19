using FluentAssertions;
using Playground.Interview;
using System.Linq;
using Xunit;

namespace Playground.UnitTests.Interview
{
    public class Problem3UnitTests
    {
        [Theory]
        [InlineData(new[] { 3, 2, 1, 3, 1 }, new[] { 3, 5, 3, 5, 5 }, 2)]
        public void Test(int[] used, int[] totalCapacity, int expected)
        {
            var result = Problem3.DoStuff(used.ToList(), totalCapacity.ToList());

            result.Should().Be(expected);
        }
    }
}
