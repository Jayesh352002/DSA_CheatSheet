using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class TwoSum
    {
        public static int[] GetTwoSumArray(int[] arr, int sum)
        {
            HashSet<int> result = new HashSet<int>();

            foreach(var item in arr)
            {
                int sub = sum - item;
                if (!result.Contains(sub))
                {
                    return new[] {item,sub} ;
                }
            }
            return new[] { 0, 0 };
        }
    }
}
