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
    public class FindPivotIndexTests
    {
        [Test()]
        public void PivotIndexTest()
        {
            int[] test = new int[] { 1, 7, 3, 6, 5, 6 };
            int result = new FindPivotIndex().PivotIndex(test);
            int expected = 3;
            Assert.AreEqual(expected, result);
        }
    }
}