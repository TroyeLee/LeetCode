using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LinkedList;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class CommonUtilTests
    {
        [Test()]
        public void ConvertToCamelCaseTest()
        {
            string title = "contains-duplicate-ii";
            string result = new CommonUtil().ConvertToCamelCase(title);
        }

        [Test()]
        public void MatchRomeTest()
        {
            string word = "aia";

            bool result = new CommonUtil().MatchRome(word);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void MatchRomeTest02()
        {
            string word = "abc";

            bool result = new CommonUtil().MatchRome(word);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void MatchRomeTest03()
        {
            string word = "ii";

            bool result = new CommonUtil().MatchRome(word);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void MatchRomeTest04()
        {
            string word = "iv";

            bool result = new CommonUtil().MatchRome(word);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void MatchRomeTest05()
        {
            string word = "iva";

            bool result = new CommonUtil().MatchRome(word);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void MatchRomeTest06()
        {
            string word = "ixv";

            bool result = new CommonUtil().MatchRome(word);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
    }
}