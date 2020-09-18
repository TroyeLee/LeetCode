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
    public class ReverseWordsInAStringIIITests
    {
        [Test()]
        public void ReverseWordsTest()
        {
            string test = "Let's take LeetCode contest";
            string result = new ReverseWordsInAStringIII().ReverseWords(test);
            string expected = "s'teL ekat edoCteeL tsetnoc";
            Assert.AreEqual(expected, result);
        }
    }
}