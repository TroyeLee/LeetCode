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
    public class ReverseStringCSTests
    {
        [Test()]
        public void ReverseStringTest()
        {
            char[] test = { 'h', 'e', 'l', 'l', 'o' };
            new ReverseStringCS().ReverseString(test);
            char[] expected = { 'o', 'l', 'l', 'e', 'h' };
            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(expected[i], test[i]);
            }
        }
    }
}