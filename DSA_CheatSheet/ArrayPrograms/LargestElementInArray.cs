using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class LargestElementInArray
    {
        public static int GetLargestElement(int[] arr)
        {
            int max = arr[0];

            for (int i=1;  i < arr.Length;  i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
