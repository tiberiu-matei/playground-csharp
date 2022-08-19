using System;

namespace Playground.LeetCode
{
    public class StraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            var rise = coordinates[1][1] - coordinates[0][1];
            var run = coordinates[1][0] - coordinates[0][0];
            var slope = Math.Abs((double)rise / run);

            for (var i = 2; i < coordinates.Length; i++)
            {
                rise = coordinates[i][1] - coordinates[0][1];
                run = coordinates[i][0] - coordinates[0][0];
                if (Math.Abs((double)rise / run) != slope)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
