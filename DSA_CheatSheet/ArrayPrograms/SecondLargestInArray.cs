using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class SecondLargestInArray
    {
        public static int GetSecondLargestElement(int[] arr)
        {
            int max = int.MinValue, secondMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if ((arr[i] > secondMax) && (arr[i] != max))
                {
                    secondMax = arr[i];
                }
            }

            return secondMax;
        }
    }
}
