using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class ShellSort
    {
        public static void Sort(IComparable[] a)
        {
            int n = a.Length;
            int h = 1;
            while (h < n / 3) h = 3 * h + 1; // 1 4 7 10

            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    for (int j = i; j >= h && Less(a[j], a[j - h]); j -= h)
                    {
                        Exchange(a, j, j - h);
                    }
                }
                h = h / 3;
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
