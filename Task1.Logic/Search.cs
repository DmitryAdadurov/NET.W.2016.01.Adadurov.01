using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Logic
{
    public class Search
    {
        public static int? BinarySearch(int[] array, int key)
        {
            int left = -1;
            int right = array.Length;
            int middle;

            while (left < right - 1)
            {
                middle = left + (right - left) / 2;
                int result = array[middle].CompareTo(key);



                if (array[middle] < key)
                {
                    left = middle;
                }
                else if (array[middle] > key)
                {
                    right = middle;
                }
                else
                {
                    return middle;
                }
            }
            return null;
        }
    }
}
