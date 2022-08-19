using FluentAssertions;
using Playground.LeetCode;
using Xunit;

namespace Playground.UnitTests.LeetCode
{
    public class RansomNoteUnitTests
    {
        private readonly RansomNote service = new RansomNote();

        [Theory]
        [InlineData(null, "abc", false)]
        [InlineData("abc", null, false)]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        [InlineData("dora", "aabcdeorstx", true)]
        [InlineData("dhurata", "dora", false)]
        [InlineData("", "", true)]
        public void RansomNote(string ransomNote, string magazine, bool expected)
        {
            var result = this.service.CanConstruct(ransomNote, magazine);

            result.Should().Be(expected);
        }
    }
}
