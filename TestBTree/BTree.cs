using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    public class BTree<TK, TP> where TK : IComparable<TK>
    {
        public int Degree { get; private set; }
        public int Heigth { get; private set; }

        public BTree(int degree)
        {
            this.Degree = degree;
            this.Heigth = 1;
        }
    }
}
