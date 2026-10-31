using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class RemoveDuplicateFromString
    {
        public static string GetUniqueString(string str)
        {
            HashSet<char> chars = new HashSet<char>();
            if(str.Length == 0)
            {
                return "Null";
            }
            foreach (char c in str) 
            { 
                chars.Add(c);
            }
            return new string(chars.ToArray());
        }
    }
}
