using NUnit.Framework;
using LeetCode.QueueStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack.Tests
{
    [TestFixture()]
    public class _01MatrixTests
    {
        [Test()]
        public void UpdateMatrixTest()
        {
            int[][] matrix = new int[][] {
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{1,1,1}
        };
            int[][] expected = new int[][] {
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{1,2,1}
        };

            int[][] result = new _01Matrix().UpdateMatrix(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }

        [Test()]
        public void UpdateMatrixTest02()
        {
            int[][] matrix = new int[][] {
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{1,1,1},
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{1,1,1}
        };
            int[][] expected = new int[][] {
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{1,1,1 },
            new int[]{0,0,0},
            new int[]{0,1,0},
            new int[]{1,2,1}
        };

            int[][] result = new _01Matrix().UpdateMatrix(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
    }
}