using System.Collections.Generic;

namespace Playground.HackerRank
{
    public static class QuickSortSplit
    {
        public static int[] Split(int[] arr)
        {
            var pivot = arr[0];
            var leftList = new List<int>();
            var middleList = new List<int> { pivot };
            var rightList = new List<int>();

            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];

                if (value < pivot)
                {
                    leftList.Add(value);
                }
                else if (value == pivot)
                {
                    middleList.Add(value);
                }
                else
                {
                    rightList.Add(value);
                }
            }

            leftList.AddRange(middleList);
            leftList.AddRange(rightList);

            return leftList.ToArray();
        }
    }
}
