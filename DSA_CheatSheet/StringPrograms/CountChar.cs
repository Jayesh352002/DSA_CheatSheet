using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class CountChar
    {
        public static int CountCharacter(string input, char ch)
        {
            input = input.ToLowerInvariant();
            ch = char.ToLowerInvariant(ch);
            int count = 0;
            foreach (char c in input)
            {
                if (c == ch)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
