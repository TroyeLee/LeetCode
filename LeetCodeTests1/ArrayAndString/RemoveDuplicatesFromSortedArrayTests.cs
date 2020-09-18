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
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Test()]
        public void RemoveDuplicatesTest()
        {
            int[] test = { 1, 1, 2 };
            int result = new RemoveDuplicatesFromSortedArray().RemoveDuplicates(test);
            int expected = 2;
            Assert.AreEqual(expected, result);
    }
    }
}