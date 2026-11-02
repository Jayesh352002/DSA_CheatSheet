using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class PlusOne
    {
        public static int[] GetNewPlusOneArray(int[] arr)
        {
            int n = arr.Length;
            for(int i=n-1; i>=0; i--)
            {
                if (arr[i] < 9)
                {
                    arr[i]++;
                    return arr;
                }
                arr[i] = 0;
            }
            int [] newArr = new int[n + 1];
            newArr[0] = 1;
            return newArr;
        }
    }
}
