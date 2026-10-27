using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class CountVowel
    {
        public static int CountVowels(string input)
        {
            input = input.ToLowerInvariant();
            int count = 0;
            string vowels = "aeiou";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
