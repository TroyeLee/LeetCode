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
    public class ZeroMatrixLcciTests
    {
        [Test()]
        public void SetZeroesTest()
        {
            int[][] test = new int[][] {
                new int[]{ 1,1,1},
                new int[]{ 1,0,1},
                new int[]{ 1,1,0}
            };
            new ZeroMatrixLcci().SetZeroes(test);
            int[][] expected =
            {
                new int[]{1,0,0 },
                new int[]{0,0,0},
                new int[]{0,0,0}
            };
            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < test[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], test[i][j]);
                }
            }
        }
    }
}