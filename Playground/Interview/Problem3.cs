using System.Collections.Generic;
using System.Linq;

namespace Playground.Interview
{
    public static class Problem3
    {
        public static int DoStuff(List<int> used, List<int> totalCapacity)
        {
            var usedData = used.Sum();
            var dataToStore = usedData;
            var orderedCapacity = totalCapacity.OrderByDescending(e => e).ToList();

            var partitionsNeeded = 0;
            for (var i = 0; i < orderedCapacity.Count; i++)
            {
                partitionsNeeded++;
                dataToStore -= orderedCapacity[i];

                if (dataToStore <= 0)
                {
                    break;
                }
            }

            return partitionsNeeded;
        }
    }
}
