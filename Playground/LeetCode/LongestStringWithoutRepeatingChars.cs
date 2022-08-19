using System;
using System.Collections.Generic;

namespace Playground.LeetCode
{
    public class LongestStringWithoutRepeatingChars
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var maxLength = 0;
            var characterMapping = new Dictionary<char, int>();
            var startIndex = 0;
            var i = 0;
            while (i < s.Length)
            {
                if (characterMapping.TryGetValue(s[i], out int lastIndexOfChar) && lastIndexOfChar >= startIndex)
                {
                    maxLength = Math.Max(maxLength, i - startIndex);
                    startIndex = lastIndexOfChar + 1;
                }

                characterMapping[s[i]] = i;
                i++;
            }

            return Math.Max(maxLength, i - startIndex);
        }
    }
}
