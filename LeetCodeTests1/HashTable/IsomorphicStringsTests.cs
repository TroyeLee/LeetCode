using NUnit.Framework;
using LeetCode.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable.Tests
{
    [TestFixture()]
    public class IsomorphicStringsTests
    {
        [Test()]
        public void IsIsomorphicTest()
        {
            string s = "egg";
            string t = "add";

            bool result = new IsomorphicStrings().IsIsomorphic(s, t);
            Assert.AreEqual(true, result);
        }
        [Test()]
        public void IsIsomorphicTest02()
        {
            string s = "foo";
            string t = "bar";

            bool result = new IsomorphicStrings().IsIsomorphic(s, t);
            Assert.AreEqual(false, result);
        }
        [Test()]
        public void IsIsomorphicTest03()
        {
            string s = "paper";
            string t = "title";

            bool result = new IsomorphicStrings().IsIsomorphic(s, t);
            Assert.AreEqual(true, result);
        }

        [Test()]
        public void IsIsomorphicTest04()
        {
            string s = "ab";
            string t = "aa";

            bool result = new IsomorphicStrings().IsIsomorphic(s, t);
            Assert.AreEqual(false, result);
        }


        [Test()]
        public void IsIsomorphicTest05()
        {
            string s = "egg";
            string t = "add";

            bool result = new IsomorphicStrings().IsIsomorphic02(s, t);
            Assert.AreEqual(true, result);
        }
        [Test()]
        public void IsIsomorphicTest06()
        {
            string s = "foo";
            string t = "bar";

            bool result = new IsomorphicStrings().IsIsomorphic02(s, t);
            Assert.AreEqual(false, result);
        }
        [Test()]
        public void IsIsomorphicTest07()
        {
            string s = "paper";
            string t = "title";

            bool result = new IsomorphicStrings().IsIsomorphic02(s, t);
            Assert.AreEqual(true, result);
        }

        [Test()]
        public void IsIsomorphicTest08()
        {
            string s = "ab";
            string t = "aa";

            bool result = new IsomorphicStrings().IsIsomorphic02(s, t);
            Assert.AreEqual(false, result);
        }
    }
}