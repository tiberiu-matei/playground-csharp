using FluentAssertions;
using Playground.HackerRank;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class ArrayManipulationUnitTests
    {
        [Theory]
        [ClassData(typeof(ArrayManipulationDataGenerator))]
        public void ManipulateArray(int n, int[][] queries, long expected)
        {
            var result = ArrayManipulation.ManipulateArray(n, queries);

            result.Should().Be(expected);
        }

        public class ArrayManipulationDataGenerator : IEnumerable<object[]>
        {
            private readonly List<object[]> _data = new List<object[]>
            {
                new object[] {5, new int[][] { new int[] { 1, 2, 100 }, new int[] { 2, 5, 100 }, new int[] { 3, 4, 100 } }, 200 },
                new object[] {3, new int[][] { new int[] { 1, 2, 50 }, new int[] { 2, 3, 100 } }, 150 },
                new object[] {3, new int[][] { new int[] { 1, 2, 0 }, new int[] { 2, 3, 0 } }, 0 },
            };

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
