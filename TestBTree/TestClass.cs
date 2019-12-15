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
        public void TestSuccess()
        {
            Assert.AreEqual(1, 1);
        }
        [Test]
        public void TestFail()
        {
            Assert.AreEqual(1, 4);
        }
    }
}
