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
    public class ImplementStrstrTests
    {
        [Test()]
        public void StrStrTest()
        {
            string haystack = "hello", needle = "ll";
            int result = new ImplementStrstr().StrStr(haystack,needle);
            int expected = 2;
            Assert.AreEqual(expected, result);
        }
    }
}