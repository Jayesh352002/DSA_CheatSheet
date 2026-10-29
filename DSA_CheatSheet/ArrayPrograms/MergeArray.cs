using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class MergeArray
    {
        public static int[] GetMergeSortedArray(int[] arr1, int[] arr2)
        {
            int[] result =  new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while(i<arr1.Length && j < arr2.Length)
            {
                result[k++] = arr1[i] < arr2[j] ? arr1[i++] : arr2[j++];
            }

            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }

            while (j < arr2.Length) 
            {
                result[k++] = arr2[j++];
            }
            return result;
        }
    }
}
