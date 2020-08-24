using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class NumberOfIslandsDFS
    {
        /// <summary>
        /// 1.岛屿数量
        /// 给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。
        /// 岛屿总是被水包围，并且每座岛屿只能由水平方向或竖直方向上相邻的陆地连接形成。
        /// 此外，你可以假设该网格的四条边均被水包围。
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            if (grid.Length == 0)
            {
                return 0;
            }
            int result = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;
            bool[,] marked = new bool[rows, cols];
            int[][] direction = new int[][] {
            new int[] { 1 , 0},
            new int[] { -1 , 0},
            new int[] { 0 , 1},
            new int[] { 0,-1}
            };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //对岛屿进行标记，如果是未标记的，则为新岛屿
                    if (!marked[i, j] && grid[i][j] == '1')
                    {
                        result++;
                        DFS(i, j, grid, marked, direction);
                    }
                }
            }


            return result;
        }

        private void DFS(int i, int j, char[][] grid, bool[,] marked, int[][] direction)
        {

            marked[i, j] = true;

            for (int t = 0; t < 4; t++)
            {
                int newX = i + direction[t][0];
                int newY = j + direction[t][1];
                if (InArea(newX, newY, grid) && !marked[newX, newY] && grid[newX][newY] == '1')
                {
                    DFS(newX, newY, grid, marked, direction);
                }
            }
        }

        private bool InArea(int i, int j, char[][] grid)
        {
            return i >= 0 && i < grid.Length && j >= 0 && j < grid[0].Length;
        }
    }
}
