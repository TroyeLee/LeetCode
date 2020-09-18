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
    public class GroupAnagramsCSTests
    {
        [Test()]
        public void GroupAnagramsTest()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = new GroupAnagramsCS().GroupAnagrams(strs);
            
        }

        [Test()]
        public void GroupAnagramsTest02()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = new GroupAnagramsCS().GroupAnagrams02(strs);

        }

        [Test()]
        public void GroupAnagramsTest03()
        {
            string[] strs = { "b","ac" };
            IList<IList<string>> result = new GroupAnagramsCS().GroupAnagrams02(strs);

        }

        [Test()]
        public void GroupAnagramsTest04()
        {
            string[] strs = { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" };
            IList<IList<string>> result = new GroupAnagramsCS().GroupAnagrams02(strs);

        }
    }
}