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
    public class DiagonalTraverseTests
    {
        [Test()]
        public void FindDiagonalOrderTest()
        {
            int[][] test =
            {
                new int[]{1,2,3 },
                new int[]{4,5,6 },
                new int[]{7,8,9 },
            };
            int[] result = new DiagonalTraverse().FindDiagonalOrder(test);

            int[] expected = { 1,2,4,7,5,3,6,8,9};

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}