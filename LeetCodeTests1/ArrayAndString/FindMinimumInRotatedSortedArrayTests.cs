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
    public class FindMinimumInRotatedSortedArrayTests
    {
        [Test()]
        public void FindMinTest()
        {
            int[] test = new int[] { 3, 4, 5, 1, 2 };
            int result = new FindMinimumInRotatedSortedArray().FindMin(test);
            int expected = 1;
            Assert.AreEqual(expected, result);
        }
    }
}