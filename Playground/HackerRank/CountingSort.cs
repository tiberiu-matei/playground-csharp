namespace Playground.HackerRank
{
    public static class CountingSort
    {
        public static int[] Sort(int[] arr)
        {
            var occurences = new int[100];

            for (var i = 0; i < arr.Length; i++)
            {
                occurences[arr[i]]++;
            }

            return occurences;
        }
    }
}
