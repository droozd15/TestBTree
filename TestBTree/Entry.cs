using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    public class Entry<T> : IEquatable<Entry<T>>
    {
        public T Value { get; set; }

        public bool Equals(Entry<T> other)
        {
            return this.Value.Equals(other.Value);
        }
    }
}
