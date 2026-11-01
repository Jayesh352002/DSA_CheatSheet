using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class RemoveCharacter
    {
        public static string GetNewStringAfterRemoval(string str, char ch)
        {
            str = str.ToLower();
            ch = char.ToLower(ch);

            string result = "";
            foreach (char c in str)
            { 
                if(c!= ch)
                {
                    result+= c;
                }
            }
            return result;
        }
    }
}
