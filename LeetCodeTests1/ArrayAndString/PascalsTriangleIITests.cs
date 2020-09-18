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
    public class PascalsTriangleIITests
    {
        [Test()]
        public void GetRowTest()
        {
            IList<int> result = new PascalsTriangleII().GetRow(3);
            IList<int> expected = new List<int> {1,3,3,1 };
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}