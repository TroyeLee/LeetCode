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
    public class TargetSumTests
    {
        [Test()]
        public void FindTargetSumWaysTest()
        {
            int[] test = new int[] { 1, 1, 1, 1, 1 };
            int result = new TargetSum().FindTargetSumWays(test, 3);
            int expected = 5;
            Assert.AreEqual(expected, result);
        }
    }

    
}