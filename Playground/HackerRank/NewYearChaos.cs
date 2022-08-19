using Playground.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Playground.HackerRank
{
    public class NewYearChaos
    {
        private readonly IConsole _console;

        public NewYearChaos(IConsole console)
        {
            _console = console;
        }

        public void MinimumBribes(int[] q)
        {
            var numberOfBribes = 0;
            var processed = new List<int>();

            for (var i = 0; i < q.Length; i++)
            {
                var bribed = q[i] - processed.Where(x => x < q[i]).Count() - 1;

                if (bribed > 2)
                {
                    _console.WriteLine("Too chaotic");

                    return;
                }

                numberOfBribes += bribed;
                processed.Add(q[i]);
            }

            _console.WriteLine(numberOfBribes.ToString());
        }
    }
}
