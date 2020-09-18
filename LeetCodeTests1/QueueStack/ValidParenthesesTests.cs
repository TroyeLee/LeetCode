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
    public class ValidParenthesesTests
    {
        [Test()]
        public void IsValidTest()
        {
            string s = "{{}}[[]]{[]}";
            bool result = new ValidParentheses().IsValid(s);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
    }
}