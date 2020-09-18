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
    public class MergeIntervalsTests
    {
        [Test()]
        public void MergeTest()
        {
            int[][] test02 = {
            new int[]{2,3},
            new int[]{ 5,5},
            new int[]{ 2,2},
            new int[]{ 3,4},
            new int[]{ 3,4}
            };

            int[][] result = new MergeIntervals().Merge(test02);
            int[][] expected =
            {
                new int[] {2,4},
                new int[] { 5,5 },
            };

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
    }
}