using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class SelectionSort
    {
        public static int[] GetSortedArray(int[] arr)
        {
            for(int i=0; i<arr.Length-1; i++)
            {
                int minIndex = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            return arr;
        }
    }
}
