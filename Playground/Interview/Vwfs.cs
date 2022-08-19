using System;
using System.Linq;

namespace Playground.Interview
{
    public static class Vwfs
    {
        public static string DoStuff(string unsortedInput)
        {
            try
            {
                var splitString = unsortedInput.Split(' ');
                var numbers = splitString.Select(stringNumber => Convert.ToInt32(stringNumber)).ToList();
                numbers.Sort();

                var sortedOutput = "";
                numbers.ForEach(number => sortedOutput += $"{number} ");

                return sortedOutput.Substring(0, sortedOutput.Length - 1);
            }
            catch (Exception)
            {
                return "Error with sorting";
            }
        }
    }
}
