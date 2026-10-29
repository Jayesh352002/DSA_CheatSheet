using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class ThirdSmallestInArray
    {
        public static int GetThirdSmallestElement(int[] arr)
        {
            int min = int.MaxValue, secondMin = int.MaxValue, thirdMin = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    thirdMin = secondMin;
                    secondMin = min;
                    min = arr[i];
                }
                else if (arr[i] < secondMin && arr[i] != min)
                {
                    thirdMin = secondMin;
                    secondMin = arr[i];
                }
                else if (arr[i] < thirdMin && arr[i] != secondMin && arr[i] != thirdMin) 
                { 
                    thirdMin = arr[i];
                }
            }
            return thirdMin;
        }
    }
}
