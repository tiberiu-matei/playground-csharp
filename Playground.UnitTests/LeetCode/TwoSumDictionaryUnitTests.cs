using FluentAssertions;
using Playground.LeetCode;
using Xunit;

namespace Playground.UnitTests.LeetCode
{
    public class TwoSumDictionaryUnitTests
    {
        [Fact]
        public void GivenValidTarget_GetSumIndices_ShouldReturnCorrectValues()
        {
            var numbers = new int[] { 2, 7, 11, 15, 17 };
            var twoSum = new TwoSumDictionary();

            var result = twoSum.GetSumIndices(numbers, 13);

            result.Length.Should().Be(2);
            result.Should().Contain(0);
            result.Should().Contain(2);
        }

        [Fact]
        public void GivenUnsortedNumers_GetSumIndices_ShouldReturnCorrectValues()
        {
            var numbers = new int[] { 3, 2, 4 };
            var twoSum = new TwoSumDictionary();

            var result = twoSum.GetSumIndices(numbers, 6);

            result.Length.Should().Be(2);
            result.Should().Contain(1);
            result.Should().Contain(2);
        }

        [Fact]
        public void GivenDuplicateValues_GetSumIndices_ShouldReturnCorrectValues()
        {
            var numbers = new int[] { 3, 3 };
            var twoSum = new TwoSumDictionary();

            var result = twoSum.GetSumIndices(numbers, 6);

            result.Length.Should().Be(2);
            result.Should().Contain(0);
            result.Should().Contain(1);
        }

        [Fact]
        public void GivenDuplicateZeroes_GetSumIndices_ShouldReturnCorrectValues()
        {
            var numbers = new int[] { 0, 4, 3, 0 };
            var twoSum = new TwoSumDictionary();

            var result = twoSum.GetSumIndices(numbers, 0);

            result.Length.Should().Be(2);
            result.Should().Contain(0);
            result.Should().Contain(3);
        }

        [Fact]
        public void GivenNegativeNumbers_GetSumIndices_ShouldReturnCorrectValues()
        {
            var numbers = new int[] { -3, 4, 3, 90 };
            var twoSum = new TwoSumDictionary();

            var result = twoSum.GetSumIndices(numbers, 0);

            result.Length.Should().Be(2);
            result.Should().Contain(0);
            result.Should().Contain(2);
        }

        [Fact]
        public void GivenBigNumbers_GetSumIndices_ShouldReturnCorrectValues()
        {
            var numbers = new int[] { 5000, 3, 2, 4, 5000 };
            var twoSum = new TwoSumDictionary();

            var result = twoSum.GetSumIndices(numbers, 10000);

            result.Length.Should().Be(2);
            result.Should().Contain(0);
            result.Should().Contain(4);
        }
    }
}
