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
    public class RotateMatrixLcciTests
    {
        [Test()]
        public void RotateTest()
        {
            int[][] test = { 
            new int[]{1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
            };

            new RotateMatrixLcci().Rotate(test);

            int[][] expected = {
            new int[]{ 7,4,1},
            new int[]{8,5,2},
            new int[]{9,6,3}
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