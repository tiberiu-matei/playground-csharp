namespace Playground.HackerRank
{
    public static class CountingSortFinal
    {
        public static int[] Sort(int[] arr)
        {
            var occurences = new int[100];

            for (var i = 0; i < arr.Length; i++)
            {
                occurences[arr[i]]++;
            }

            var sortedArray = new int[arr.Length];
            var index = 0;

            for (var i = 0; i < occurences.Length; i++)
            {
                for (var j = 0; j < occurences[i]; j++)
                {
                    sortedArray[index] = i;
                    index++;
                }
            }

            return sortedArray;
        }
    }
}
