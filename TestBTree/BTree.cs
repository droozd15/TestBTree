﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    public class BTree<T> where T : IComparable<T>
    {
        public int Degree { get; private set; }
        public int Height { get; private set; }

        public Node<T> Root { get; private set; }

        public BTree(int degree)
        {
            this.Degree = degree;
            this.Height = 1;
            this.Root = new Node<T>(degree);
        }

        public void Insert(T value)
        {
            if (!Root.HasReachedMaxEntries)
            {
                int positionToInsert = Root.Entries.TakeWhile(entry => value.CompareTo(entry.Value) >= 0).Count();
                Root.Entries.Insert(positionToInsert, new Entry<T>() { Value = value });
                return;
            }

            this.Height++;
        }

        public Entry<T> Search(T value)
        {
            int i = Root.Entries.TakeWhile(entry => value.CompareTo(entry.Value) > 0).Count();

            if (i < Root.Entries.Count && Root.Entries[i].Value.CompareTo(value) == 0)
            {
                return Root.Entries[i];
            }

            return null;
        }

        public void Delete(T value)
        {
            int i = Root.Entries.TakeWhile(entry => value.CompareTo(entry.Value) > 0).Count();

            if (i < Root.Entries.Count && Root.Entries[i].Value.CompareTo(value) == 0)
            {
                Root.Entries.RemoveAt(i);
            }
        }
    }

}
