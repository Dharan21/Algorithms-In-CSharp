using Algorithms.UnionFind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UnionFind
{
    public class QuickUnionUF : IUF
    {
        private int[] id;
        public QuickUnionUF(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int rootP = Root(p);
            int rootQ = Root(q);
            id[rootP] = rootQ;
        }

        private int Root(int i)
        {
            while(i != id[i])
            {
                i = id[i];
            }
            return i;
        }
    }
}
