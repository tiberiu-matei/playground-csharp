using System.Collections.Generic;
using System.Linq;

namespace Playground.HackerRank
{
    public static class CountTriplets
    {
        public static long Count(List<long> arr, long r)
        {
            var array = arr.ToArray();

            var occurences = new Dictionary<long, List<long>>();
            long combinations = 0;

            for (long i = array.Length - 1; i >= 0; i--)
            {
                if (occurences.ContainsKey(array[i] * r))
                {
                    var validEntries = occurences[array[i] * r];
                    if (occurences.ContainsKey(array[i] * r * r))
                    {
                        foreach (var validEntry in validEntries)
                        {
                            combinations += occurences[array[i] * r * r].Where(e => e > validEntry).Count();
                        }
                    }
                }

                if (occurences.ContainsKey(array[i]))
                {
                    occurences[array[i]].Add(i);
                }
                else
                {
                    occurences[array[i]] = new List<long> { i };
                }
            }

            return combinations;
        }
    }
}
