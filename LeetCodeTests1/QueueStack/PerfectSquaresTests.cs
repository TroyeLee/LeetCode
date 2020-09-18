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
    public class PerfectSquaresTests
    {
        [Test()]
        public void NumSquaresTest()
        {
            int result03 = new PerfectSquares().NumSquares(12);
            int expected = 3;
            Assert.AreEqual(expected, result03);
        }
    }
}