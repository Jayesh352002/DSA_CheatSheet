using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class LongestSubString
    {
        public static string GetLongestSubString(string str)
        {
            var splitStr = str.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for(int i=0; i<splitStr.Length; i++)
            {
                wordCount[splitStr[i]] = splitStr[i].Length;  
            }

            var longestWord = wordCount.OrderByDescending(x => x.Value).FirstOrDefault();
            return longestWord.Key;
        }
    }
}
