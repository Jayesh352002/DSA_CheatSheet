using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CheatSheet.ArrayPrograms
{
    public class RemoveDuplicatesFromArray
    {
        public static int[] GetUniqueArray(int[] arr)
        {
            HashSet<int> unique = new HashSet<int> ();
            foreach(var item in arr)
            {
                unique.Add (item);
            }
            return unique.ToArray();
        }
    }
}
