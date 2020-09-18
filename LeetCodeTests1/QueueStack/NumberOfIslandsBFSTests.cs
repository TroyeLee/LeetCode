using NUnit.Framework;
using LeetCode.QueueStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack.Tests
{
    [TestFixture()]
    public class NumberOfIslandsBFSTests
    {
        [Test()]
        public void NumIslandsTest()
        {
            char[][] test01 = {
            new char[]{'1', '1', '1'},
            new char[]{'0', '1', '0'},
            new char[]{'1', '1', '1'},
            new char[]{'0', '0', '0'}
            };

            int result = new NumberOfIslandsBFS().NumIslands(test01);

            int expected = 1;

            Assert.AreEqual(expected,result);
        }
    }
}