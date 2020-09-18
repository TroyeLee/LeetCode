using NUnit.Framework;
using LeetCode.ArrayAndString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString.Tests
{
    [TestFixture()]
    public class MinimumSizeSubarraySumTests
    {
        [Test()]
        public void MinSubArrayLenTest()
        {
            int[] test = new int[] { 2, 3, 1, 2, 4, 3 };
            int result = new MinimumSizeSubarraySum().MinSubArrayLen(3, test);
            int expected = 1;
            Assert.AreEqual(expected, result);
        }
    }
}