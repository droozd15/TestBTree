﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree<int> tree = new BTree<int>(2);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            tree.Insert(11);
            tree.Insert(12);
            tree.Insert(13);
            tree.Insert(14);
            tree.Insert(15);
            tree.Insert(16);
            tree.Insert(17);
        }
    }
}
