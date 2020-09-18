using NUnit.Framework;
using LeetCode.QueueStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack.Tests
{
    [TestFixture()]
    public class DecodeStringCSTests
    {
        [Test()]
        public void DecodeStringTest()
        {
            string test = "3[a]2[bc3[d]]";
            string result = new DecodeStringCS().DecodeString(test);

            string expected = "aaabcdddbcddd";

            Assert.AreEqual(expected,result);

        }
    }
}