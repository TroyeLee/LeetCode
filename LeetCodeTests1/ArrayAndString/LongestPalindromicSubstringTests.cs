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
    public class LongestPalindromicSubstringTests
    {
        [Test()]
        public void longestPalindromeTest()
        {
            string test = "babad";
            string result = new LongestPalindromicSubstring().longestPalindrome(test);
            string expected = "bab";
            Assert.AreEqual(expected,result);
        }

        [Test()]
        public void LongestPalindrome02Test()
        {
            string test = "babad";
            string result = new LongestPalindromicSubstring().longestPalindrome(test);
            string expected = "bab";
            Assert.AreEqual(expected, result);
        }
    }
}