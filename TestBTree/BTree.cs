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
        public int Height { get; private set; }
        public Node<TK, TP> Root { get; private set; }

        public BTree(int degree)
        {
            this.Degree = degree;
            this.Height = 1;
            this.Root = new Node<TK, TP>(degree);
        }
    }
}
