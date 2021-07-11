using Algorithms.UnionFind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UnionFind
{
    public class WeightedQuickUnionUF : IUF
    {
        private int[] id;
        private int[] sz;
        public WeightedQuickUnionUF(int n)
        {
            id = new int[n];
            sz = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
                sz[i] = 1;
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
            if (rootP == rootQ) return;
            // add smaller tree as a child of larger trees root node.
            if (sz[rootP] < sz[rootQ])
            {
                id[rootP] = rootQ;
                sz[rootQ] += sz[rootP];
            }
            else
            {
                id[rootQ] = rootP;
                sz[rootP] += sz[rootQ];
            }
        }
        private int Root(int i)
        {
            while (i != id[i])
            {
                id[i] = id[id[i]]; // For flattening the tree
                i = id[i];
            }
            return i;
        }
    }
}
