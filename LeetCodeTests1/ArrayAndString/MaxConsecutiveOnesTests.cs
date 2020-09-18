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
    public class MaxConsecutiveOnesTests
    {
        [Test()]
        public void FindMaxConsecutiveOnesTest()
        {
            int[] test = new int[] { 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1 };
            int result = new MaxConsecutiveOnes().FindMaxConsecutiveOnes(test);
            int expected = 4;
            Assert.AreEqual(expected, result);
        }
    }
}