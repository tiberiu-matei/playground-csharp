using System;

namespace Playground.HackerRank
{
    public static class SockMatch
    {
        public static int MatchSocks(int n, int[] ar)
        {
            Array.Sort(ar);

            var numberOfPairs = 0;

            for (var i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    numberOfPairs++;
                    i++;
                }
            }

            return numberOfPairs;
        }
    }
}
