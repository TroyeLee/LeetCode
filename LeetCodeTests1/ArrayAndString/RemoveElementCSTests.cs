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
    public class RemoveElementCSTests
    {
        [Test()]
        public void RemoveElementTest()
        {
            int[] test = { 1, 2, 3, 4 };
            int result02 = new RemoveElementCS().RemoveElement(test, 2);
            int expected = 3;
            Assert.AreEqual(expected, result02);

        }
    }
}