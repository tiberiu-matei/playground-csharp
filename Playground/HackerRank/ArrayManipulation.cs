namespace Playground.HackerRank
{
    public static class ArrayManipulation
    {
        public static long ManipulateArray(int n, int[][] queries)
        {
            var array = new long[n];

            long max = 0;

            foreach (var query in queries)
            {
                for (var i = query[0] - 1; i < query[1]; i++)
                {
                    array[i] += query[2];

                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }

            return max;
        }
    }
}
