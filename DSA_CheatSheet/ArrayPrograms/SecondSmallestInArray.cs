using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class SecondSmallestInArray
    {
        public static int GetSecondSmallestElement(int[] arr)
        {
            int min = int.MaxValue, secondMin = int.MaxValue;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] < min)
                {
                    secondMin = min;
                    min = arr[i];
                }
                else if (arr[i] < secondMin && arr[i] != min)
                {
                    secondMin = arr[i];
                }
            }
            return secondMin;
        }
    }
}
