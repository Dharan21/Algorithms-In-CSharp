using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UnionFind.Interface
{
    public interface IUF
    {
        void Union(int p, int q);
        bool Connected(int p, int q);
    }
}
