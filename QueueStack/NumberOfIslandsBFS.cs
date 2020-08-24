using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class NumberOfIslandsBFS
    {
        /// <summary>
        /// 岛屿数量
        /// 给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。
        /// 岛屿总是被水包围，并且每座岛屿只能由水平方向或竖直方向上相邻的陆地连接形成。
        /// 此外，你可以假设该网格的四条边均被水包围。
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            int result = 0;
            int cols = grid[0].Length;
            int rows = grid.Length;
            int[][] direction = new int[][] {
            new int[] { -1 , 0 },
            new int[] { 1 , 0 },
            new int[] { 0 , -1 },
            new int[] { 0 , 1 }
            };

            bool[,] marked = new bool[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!marked[i, j] && grid[i][j] == '1')
                    {
                        result++;
                        marked[i, j] = true;

                        IList<int> queue = new List<int>();
                        queue.Add(i * cols + j);
                        while (queue.Count > 0)
                        {
                            int cur = queue[0];
                            int numx = cur / cols;
                            int numy = cur % cols;
                            queue.Remove(cur);
                            for (int k = 0; k < 4; k++)
                            {
                                int x = numx + direction[k][0];
                                int y = numy + direction[k][1];

                                if (InArea(x, y, grid) && !marked[x, y] && grid[x][y] == '1')
                                {
                                    marked[x, y] = true;
                                    queue.Add(x * cols + y);
                                }
                            }

                        }
                    }
                }
            }


            return result;
        }

        private bool InArea(int i, int j, char[][] grid)
        {
            return i >= 0 && i < grid.Length && j >= 0 && j < grid[0].Length;
        }
    }
}
