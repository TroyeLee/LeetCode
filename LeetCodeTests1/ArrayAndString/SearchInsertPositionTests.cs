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
    public class SearchInsertPositionTests
    {
        [Test()]
        public void SearchInsertTest()
        {
            int[] test = new int[] { 1, 3, 5, 6 };
            int result = new SearchInsertPosition().SearchInsert(test, 5);
            int expected = 2;
            Assert.AreEqual(expected, result);

        }
    }
}