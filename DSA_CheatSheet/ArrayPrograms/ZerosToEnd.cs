using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class ZerosToEnd
    {
        public static int[] MoveZerosToEnd(int[] arr)
        {
            int index = 0;
            foreach (var item in arr)
            {
                if (item != 0)
                {
                    arr[index] = item;
                    index++;
                }
            }

            while (index < arr.Length)
            {
                arr[index] = 0;
                index++;
            }

            return arr;
        }
    }
}
