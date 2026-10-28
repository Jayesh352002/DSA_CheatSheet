using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class ThirdLargestInArray
    {
        public static int GetThirdLargestElement(int[] arr)
        {
            int? max = null, secondMax = null, thirdMax = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!max.HasValue || arr[i] > max.Value)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] != max.Value && (!secondMax.HasValue || arr[i] > secondMax.Value))
                {
                    thirdMax = secondMax;
                    secondMax = arr[i];
                }
                else if (arr[i] != max.Value && arr[i] != secondMax && (!thirdMax.HasValue || arr[i] > thirdMax.Value))
                {
                    thirdMax = arr[i];
                }
            }
            return thirdMax ?? throw new InvalidOperationException("The array must contain at least three distinct values.");
        }
    }
}
