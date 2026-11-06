using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class BubbleSort
    {
        public static int[] GetSortedArray(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                bool swap = false;
                for(int j=0; j<arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }
                }
                if(!swap)
                    break;
            }
            return arr;
        }
    }
}
