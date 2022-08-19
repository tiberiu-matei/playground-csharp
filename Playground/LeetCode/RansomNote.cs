using System.Collections.Generic;

namespace Playground.LeetCode
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote == magazine)
            {
                return true;
            }

            if (ransomNote == null)
            {
                return false;
            }

            var magazineDictionary = GetDictionaryFromMagazine(magazine);

            for (var i = 0; i < ransomNote.Length; i++)
            {
                var magazineHasLetter = magazineDictionary.TryGetValue(ransomNote[i], out int charCount);
                if (magazineHasLetter && charCount > 0)
                {
                    magazineDictionary[ransomNote[i]] -= 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private Dictionary<char, int> GetDictionaryFromMagazine(string magazine)
        {
            var magazineDictionary = new Dictionary<char, int>();
            if (magazine == null)
            {
                return magazineDictionary;
            }

            for (var i = 0; i < magazine.Length; i++)
            {
                var existingKey = magazineDictionary.TryGetValue(magazine[i], out int charCount);
                if (existingKey)
                {
                    magazineDictionary[magazine[i]] += 1;
                }
                else
                {
                    magazineDictionary[magazine[i]] = 1;
                }
            }

            return magazineDictionary;
        }
    }
}
