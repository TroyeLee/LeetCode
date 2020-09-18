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
    public class SingleNumberCSTests
    {
        [Test()]
        public void SingleNumberTest()
        {
            int[] data = { 1,2,3,2,3,4,3,4,3,4};
            int result = new SingleNumberCS().SingleNumber(data);

            int expected = 1;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void SingleNumberTest02()
        {
            int[] data = { 1, 2, 3, 1, 3, 4, 3, 4, 3, 4 };
            int result = new SingleNumberCS().SingleNumber(data);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void SingleNumberTest03()
        {
            int[] data = { 1, 2, 3, 1, 3, 4, 3, 4, 3 };
            int result = new SingleNumberCS().SingleNumber02(data);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}