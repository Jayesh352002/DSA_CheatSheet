using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class RemoveVowelsFromString
    {
        public static string GetNoVowelsString(string str)
        {
            str = str.ToLower();
            //string vowels = "aeiouAEIOU";
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if(!(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'))
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
