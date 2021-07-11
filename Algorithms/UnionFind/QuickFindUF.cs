using Algorithms.UnionFind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UnionFind
{
    public class QuickFindUF : IUF
    {
        private int[] id;
        public QuickFindUF(int n)
        {
            id = new int[n];
            for(int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            int pId = id[p];
            int qId = id[q];
            for(int i = 0; i < id.Length; i++)
            {
                if (id[i] == pId)
                {
                    id[i] = qId;
                }
            }
        }

        public bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

    }
}
