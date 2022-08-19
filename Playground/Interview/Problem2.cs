using System.Collections.Generic;
using System.Linq;

namespace Playground.Interview
{
    public static class Problem2
    {
        public static List<string> DoStuff(List<string> text)
        {
            for (var i = 0; i < text.Count; i++)
            {
                var sortedFirstWord = string.Concat(text[i].OrderBy(c => c));

                for (var j = text.Count - 1; j > i; j--)
                {
                    var sortedSecondWord = string.Concat(text[j].OrderBy(c => c));

                    if (sortedFirstWord == sortedSecondWord)
                    {
                        text.RemoveAt(j);
                    }
                }
            }

            text.Sort();

            return text;
        }
    }
}
