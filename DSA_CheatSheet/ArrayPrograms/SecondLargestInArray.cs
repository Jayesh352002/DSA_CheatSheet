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
            int? max = null, secondMax = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!max.HasValue || arr[i] > max.Value)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] != max.Value && (!secondMax.HasValue || arr[i] > secondMax.Value))
                {
                    secondMax = arr[i];
                }
            }

            return secondMax ?? throw new InvalidOperationException("The array must contain at least two distinct values.");
        }
    }
}
