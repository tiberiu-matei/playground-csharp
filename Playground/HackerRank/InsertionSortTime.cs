namespace Playground.HackerRank
{
    public static class InsertionSortTime
    {
        public static int Sort(int[] arr)
        {
            var shifts = 0;

            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                var j = i - 1;
                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    shifts++;
                    j--;
                }

                j++;

                arr[j] = value;
            }

            return shifts;
        }
    }
}
