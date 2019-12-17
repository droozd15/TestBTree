using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBTree
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void CanCreateBTree()
        {
            BTree<int> tree = new BTree<int>(3);
            Assert.True(tree != null);
            Assert.AreEqual(3, tree.Degree);
            Assert.AreEqual(1, tree.Height);
            Assert.AreEqual(0, tree.Root.Entries.Count);
            Assert.AreEqual(0, tree.Root.Children.Count);
            Assert.NotNull(tree.Root.Entries);
            Assert.NotNull(tree.Root.Children);
            Assert.True(tree.Root != null);
        }

        [Test]
        public void CanInsertValuesIntoBTree()
        {
            BTree<int> tree = new BTree<int>(3);
            tree.Insert(1);
            tree.Insert(2);
            Assert.AreEqual(2, tree.Root.Entries.Count);
        }

        [Test]
        public void CanFindTheValueInTheBTree()
        {
            BTree<int> tree = new BTree<int>(3);
            tree.Insert(1);
            tree.Insert(2);
            Assert.AreEqual(1, tree.Search(1).Value);
            Assert.AreEqual(null, tree.Search(3));
        }
        [Test]
        public void CanRemoveValueFromTree()
        {
            BTree<int> tree = new BTree<int>(3);
            tree.Insert(1);
            tree.Insert(2);
            Assert.AreEqual(1, tree.Search(1).Value);
            tree.Delete(1);
            Assert.AreEqual(null, tree.Search(1));
        }

    }
}
