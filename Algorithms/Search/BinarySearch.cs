using Algorithms.Search.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public class BinarySearch : ISearch
    {
        public int Search(int[] a, int key)
        {
            int low = 0, high = a.Length - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (a[mid] == key) return mid;
                else if (a[mid] > key) high = mid - 1;
                else low = mid + 1;
            }
            return -1;
        }
    }
}
