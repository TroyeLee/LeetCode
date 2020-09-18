using NUnit.Framework;
using LeetCode.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable.Tests
{
    [TestFixture()]
    public class MyHashSetTests
    {
        [Test()]
        public void MyHashSetTest()
        {
            MyHashSet myHashSet = new MyHashSet();

            myHashSet.Add(1);
            myHashSet.Add(2);

            bool result = myHashSet.Contains(1);
            Assert.AreEqual(true, result);

            result = myHashSet.Contains(3);
            Assert.AreEqual(false, result);

            myHashSet.Add(2);
            result = myHashSet.Contains(2);
            Assert.AreEqual(true, result);
            
            myHashSet.Remove(2);
            result = myHashSet.Contains(2);
            Assert.AreEqual(false, result);
        }
    }
}