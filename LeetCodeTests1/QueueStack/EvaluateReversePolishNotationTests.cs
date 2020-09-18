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
    public class EvaluateReversePolishNotationTests
    {
        [Test()]
        public void EvalRPNTest()
        {
            string[] test = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            int result = new EvaluateReversePolishNotation().EvalRPN(test);
            int expected = 22;
            Assert.AreEqual(expected, result);

        }
    }
}