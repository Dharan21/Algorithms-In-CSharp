using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Shuffle
{
    public class RandomShuffle
    {                                       
        public static void Shuffle(object[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int r = Uniform(i);
                Exchange(a, i, r);
            }
        }

        private static int Uniform(int i)
        {
            return new Random().Next(i);
        }

        private static void Exchange(object[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
