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
    public class LongestCommonPrefixCSTests
    {
        [Test()]
        public void LongestCommonPrefixTest()
        {
            string[] test = new string[] { "flower", "flow", "flowight" };
            string result = new LongestCommonPrefixCS().LongestCommonPrefix(test);
            string expected = "flow";
            Assert.AreEqual(expected, result);
        }
    }
}