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
    public class ContainsDuplicateCSTests
    {
        [Test()]
        public void ContainsDuplicateTest()
        {
            int[] data = { 1,2,3,4} ;

            bool result = new ContainsDuplicateCS().ContainsDuplicate(data);
            bool expected = false;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsDuplicateTest02()
        {
            int[] data = { 1};

            bool result = new ContainsDuplicateCS().ContainsDuplicate(data);
            bool expected = false;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsDuplicateTest03()
        {
            int[] data = { };

            bool result = new ContainsDuplicateCS().ContainsDuplicate(data);
            bool expected = false;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsDuplicateTest04()
        {
            int[] data = { 1, 2, 3, 1};

            bool result = new ContainsDuplicateCS().ContainsDuplicate(data);
            bool expected = true;

            Assert.AreEqual(expected, result);
        }

    }
}