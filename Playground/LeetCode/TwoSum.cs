using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;

namespace Playground.LeetCode
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class TwoSum
    {
        private readonly int[] benchmarkNumbers = new int[41] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 40 };
        private readonly int benchmarkTarget = 80;

        [Benchmark]
        public int[] GetSumIndicesBenchmark() => GetSumIndices(this.benchmarkNumbers, this.benchmarkTarget);

        public int[] GetSumIndices(int[] nums, int target)
        {
            var sortedNums = new int[nums.Length];
            nums.CopyTo(sortedNums, 0);
            Array.Sort(sortedNums);

            for (var i = 0; i <= sortedNums.Length; i++)
            {
                for (var j = i; j < sortedNums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    var sum = sortedNums[i] + sortedNums[j];
                    if (sum == target)
                    {
                        return RetrieveIndicesFromValues(nums, sortedNums[i], sortedNums[j]);
                    }
                    if (sum > target)
                    {
                        break;
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        private int[] RetrieveIndicesFromValues(int[] numbers, int firstValue, int secondValue)
        {
            var firstIndex = -1;
            var secondIndex = -1;
            for (var k = 0; k < numbers.Length; k++)
            {
                if (numbers[k] == firstValue && firstIndex == -1)
                {
                    firstIndex = k;
                }
                if (numbers[k] == secondValue && k != firstIndex)
                {
                    secondIndex = k;
                }
                if (firstIndex > -1 && secondIndex > -1)
                {
                    return new int[2] { firstIndex, secondIndex };
                }
            }

            return new int[2] { -1, -1 };
        }
    }
}
