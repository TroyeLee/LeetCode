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
    public class ArrayPartitionITests
    {
        [Test()]
        public void ArrayPairSumTest()
        {
            int[] test = new int[] { 1, 3, 2, 4 };
            int result = new ArrayPartitionI().ArrayPairSum(test);
            int expect = 4;
            Assert.AreEqual(expect, result);
        }
    }
}