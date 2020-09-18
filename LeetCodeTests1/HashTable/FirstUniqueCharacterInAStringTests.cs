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
    public class FirstUniqueCharacterInAStringTests
    {
        [Test()]
        public void FirstUniqCharTest()
        {
            string s = "Hello";
            int expected = 0;
            int result = new FirstUniqueCharacterInAString().FirstUniqChar(s);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void FirstUniqCharTest02()
        {
            string s = "tenet";
            int expected = 2;
            int result = new FirstUniqueCharacterInAString().FirstUniqChar(s);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void FirstUniqCharTest03()
        {
            string s = "tennet";
            int expected = -1;
            int result = new FirstUniqueCharacterInAString().FirstUniqChar(s);
            Assert.AreEqual(expected, result);
        }
    }
}