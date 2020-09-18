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
    public class ReverseWordsInAStringTests
    {
        [Test()]
        public void ReverseWordsTest()
        {
            string test = "the sky is blue";
            string result = new ReverseWordsInAString().ReverseWords(test);
            string expected = "blue is sky the";

            Assert.AreEqual(expected, result);
        }
    }
}