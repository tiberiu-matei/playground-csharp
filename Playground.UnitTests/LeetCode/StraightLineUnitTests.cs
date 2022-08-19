using FluentAssertions;
using Playground.LeetCode;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Playground.UnitTests.LeetCode
{
    public class StraightLineUnitTests
    {
        private readonly StraightLine service = new StraightLine();

        [Theory]
        [ClassData(typeof(StraightLineDataGenerator))]

        public void RansomNote(bool expected, params int[][] coordinates)
        {
            var result = this.service.CheckStraightLine(coordinates);

            result.Should().Be(expected);
        }
    }

    public class StraightLineDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {true, new int[2] { 1, 3 }, new int[2] { 1, 5 }},
            new object[] {true, new int[2] { 1, 2 }, new int[2] { 2, 3 }, new int[2] { 3, 4 }, new int[2] { 4, 5 }},
            new object[] {false, new int[2] { 1, 2 }, new int[2] { 2, 3 }, new int[2] { 3, 8 }, new int[2] { 4, 5 }},
            new object[] {true, new int[2] { 2, 3 }, new int[2] { 1, 2 }, new int[2] { 5, 6 }},
            new object[] {true, new int[2] { -2, -1 }, new int[2] { -1, 0 }, new int[2] { 0, 1 }},
            new object[] {true, new int[2] { 5, 6 }, new int[2] { -1, 0 }, new int[2] { -2, -1 }},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
