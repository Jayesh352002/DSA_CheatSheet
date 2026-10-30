using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class ReverseArray
    {
        public static int[] GetReverseArray(int[] arr)
        {
            int left = 0, right = arr.Length-1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            return arr;

        }
    }
}
