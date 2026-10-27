using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class ReverseString
    {
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            int left = 0, right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
