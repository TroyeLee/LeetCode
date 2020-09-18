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
    public class FloodFillCSTests
    {
        [Test()]
        public void FloodFillTest()
        {
            int[][] image = { 
                new int[] { 0, 1, 1 }, 
                new int[] { 1, 1, 0 }, 
                new int[] { 1, 0, 1 } 
            };
            int sr = 1, sc = 1, newColor = 2;

            int[][] result = new FloodFillCS().FloodFill(image, sr, sc, newColor);

            int[][] expected =
            {
                new int[]{0,2,2 },
                new int[]{2,2,0 },
                new int[]{2,0,1 }
            };

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
        [Test()]
        public void FloodFillTest02()
        {
            int[][] image = {
                new int[] { 0, 1, 1,1,1,3,2 },
                new int[] { 1, 1, 0,1,2,3,3 },
                new int[] { 1, 0, 1,1,2,3,3 }
            };
            int sr = 1, sc = 1, newColor = 2;

            int[][] result = new FloodFillCS().FloodFill(image, sr, sc, newColor);

            int[][] expected =
            {
                new int[]{0,2,2 ,2,2,3,2 },
                new int[]{2,2,0 ,2,2,3,3 },
                new int[]{2,0,2 ,2,2,3,3 }
            };

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
        [Test()]
        public void FloodFillTest03()
        {
            int[][] image = {
            };
            int sr = 1, sc = 1, newColor = 2;

            int[][] result = new FloodFillCS().FloodFill(image, sr, sc, newColor);

            int[][] expected =
            {
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