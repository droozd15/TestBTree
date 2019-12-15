using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    public class Node<TK, TP>
    {
        private int _degree;
        public List<Node<TK, TP>> Children { get; set; }
        public List<Entry<TK, TP>> Entries { get; set; }

        public Node(int degree)
        {
            this._degree = _degree;
            Children = new List<Node<TK, TP>>();
            Entries = new List<Entry<TK, TP>>();
        }
    }
}
