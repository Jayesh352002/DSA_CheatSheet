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
            int max = int.MinValue, secondMax = int.MinValue, thirdMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    thirdMax = secondMax;
                    secondMax = arr[i];
                }
                else if (arr[i] > thirdMax && arr[i] != secondMax && arr[i] != max)
                {
                    thirdMax = arr[i];
                }
            }
            return thirdMax;
        }
    }
}
