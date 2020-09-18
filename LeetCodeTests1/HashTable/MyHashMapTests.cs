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
    public class MyHashMapTests
    {
        [Test()]
        public void MyHashMapTest()
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(0, 1);
            myHashMap.Put(1, 2);
            myHashMap.Put(2, 3);
            myHashMap.Put(3, 4);
            myHashMap.Put(4, 5);
            myHashMap.Put(5, 6);
            myHashMap.Put(6, 7);

            int result = myHashMap.Get(6);

            Assert.AreEqual(7, result);

            myHashMap.Remove(4);
            result = myHashMap.Get(4);
            Assert.AreEqual(-1, result);

            result = myHashMap.Get(5);
            Assert.AreEqual(6, result);
        }
        [Test()]
        public void MyHashMapTest02()
        {
            MyHashMap02 myHashMap = new MyHashMap02();
            myHashMap.Put(0, 1);
            myHashMap.Put(1, 2);
            myHashMap.Put(2, 3);
            myHashMap.Put(3, 4);
            myHashMap.Put(4, 5);
            myHashMap.Put(5, 6);
            myHashMap.Put(6, 7);

            int result = myHashMap.Get(6);

            Assert.AreEqual(7, result);

            myHashMap.Remove(4);
            result = myHashMap.Get(4);
            Assert.AreEqual(-1, result);

            result = myHashMap.Get(5);
            Assert.AreEqual(6, result);
        }
    }
}