using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class InsertionSort
    {
        public static void Sort(IComparable[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Less(a[j], a[j - 1]))
                        Exchange(a, j, j - 1);
                    else break;
                }
            }
        }

        private static bool Less(IComparable a, IComparable b)
        {
            return a.CompareTo(b) < 0;
        }

        private static void Exchange(IComparable[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
