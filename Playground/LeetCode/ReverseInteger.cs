using System;

namespace Playground.LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var reversedString = string.Empty;
            if (x < 0)
            {
                reversedString += "-";
            }

            while (x / 10 != 0)
            {
                reversedString += Math.Abs(x % 10);
                x /= 10;
            }

            reversedString += Math.Abs(x);

            int reversed;
            try
            {
                reversed = Convert.ToInt32(reversedString);
            }
            catch (OverflowException)
            {
                return 0;
            }

            return reversed;
        }
    }
}
