using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    public class Node<T>
    {
        private int _degree;
        public List<Node<T>> Children { get; set; }
        public List<Entry<T>> Entries { get; set; }

        public Node(int degree)
        {
            this._degree = _degree;
            Children = new List<Node<T>>();
            Entries = new List<Entry<T>>();
        }
    }
}
