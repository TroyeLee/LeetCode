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
    public class TwoSumIIInputArrayIsSortedTests
    {
        [Test()]
        public void TwoSumTest()
        {
            int[] test = new int[] { 1, 2, 3, 4 };
            int[] result = new TwoSumIIInputArrayIsSorted().TwoSum(test, 7);
            int[] expected = {3,4 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}