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
    public class PascalsTriangleTests
    {
        [Test()]
        public void GenerateTest()
        {
            IList<IList<int>> result = new PascalsTriangle().Generate(4);
            IList<IList<int>> expected = new List<IList<int>>() {
                new List<int>{ 1},
                new List<int>{ 1,1},
                new List<int>{1,2,1 },
                new List<int>{1,3,3,1 },
            };
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
    }
}