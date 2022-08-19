namespace Playground.Interview
{
    public static class Problem1
    {
        public static int DoStuff(string target)
        {
            var flips = 0;
            for (var i = 0; i < target.Length; i++)
            {
                if (target[i] == '1' && flips % 2 == 0)
                {
                    flips++;
                }
                else if (target[i] == '0' && flips % 2 == 1)
                {
                    flips++;
                }
            }

            return flips;
        }
    }
}
