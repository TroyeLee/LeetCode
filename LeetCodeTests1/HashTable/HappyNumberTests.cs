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
    public class HappyNumberTests
    {
        [Test()]
        public void IsHappyTest()
        {
            int n = 19;

            bool result = new HappyNumber().IsHappy(n);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void IsHappyTest02()
        {
            int n = 0;

            bool result = new HappyNumber().IsHappy(n);

            bool expected = false;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void IsHappyTest03()
        {
            int n = 1;

            bool result = new HappyNumber().IsHappy(n);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void IsHappyTest04()
        {
            int n = 7;

            bool result = new HappyNumber().IsHappy(n);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}