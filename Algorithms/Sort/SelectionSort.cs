using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class SelectionSort
    {
        public static void Sort(IComparable[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (Less(a[j], a[min]))
                        min = j;
                Exchange(a, i, min);
            }
        }

        private static bool Less(IComparable a, IComparable b)
        {
            return a.CompareTo(b) < 0;
        }

        private static void Exchange(IComparable[]a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
