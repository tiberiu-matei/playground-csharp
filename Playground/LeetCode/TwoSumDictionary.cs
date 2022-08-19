using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Generic;

namespace Playground.LeetCode
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class TwoSumDictionary
    {
        private readonly int[] benchmarkNumbers = new int[41] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 40 };
        private readonly int benchmarkTarget = 80;

        [Benchmark]
        public int[] GetSumIndicesBenchmark() => GetSumIndices(this.benchmarkNumbers, this.benchmarkTarget);

        public int[] GetSumIndices(int[] nums, int target)
        {
            var dictionary = GetDictionaryFromNumbers(nums);

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target / 2)
                {
                    if (dictionary[nums[i]][1] > -1)
                    {
                        return new int[2] { dictionary[nums[i]][0], dictionary[nums[i]][1] };
                    }
                    else
                    {
                        continue;
                    }
                }

                dictionary.TryGetValue(target - nums[i], out int[] complementValue);
                if (complementValue != null)
                {
                    return new int[2] { i, complementValue[0] };
                }
            }

            return new int[2] { -1, -1 };
        }

        private Dictionary<int, int[]> GetDictionaryFromNumbers(int[] nums)
        {
            var dictionary = new Dictionary<int, int[]>();
            for (var i = 0; i < nums.Length; i++)
            {
                dictionary.TryGetValue(nums[i], out int[] indexList);
                if (indexList != null)
                {
                    indexList[1] = i;
                }
                else
                {
                    dictionary[nums[i]] = new int[2] { i, -1 };
                }
            }

            return dictionary;
        }
    }
}
