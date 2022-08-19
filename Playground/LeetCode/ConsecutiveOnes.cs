using System;

namespace Playground.LeetCode
{
    public class ConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var currentStreak = 0;
            var maxStreak = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (currentStreak > maxStreak)
                    {
                        maxStreak = currentStreak;
                    }

                    currentStreak = 0;
                    continue;
                }

                currentStreak++;
            }

            return Math.Max(maxStreak, currentStreak);
        }
    }
}
