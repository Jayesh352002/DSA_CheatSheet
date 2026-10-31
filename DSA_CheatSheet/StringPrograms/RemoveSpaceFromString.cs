using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.StringPrograms
{
    public class RemoveSpaceFromString
    {
        public static string GetNoSpaceString(string str)
        {
            var s1 = str.Split(" ");
            var resultString = string.Join("", s1);
            return resultString;
        }
    }
}
