using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class _01Matrix
    {
        /// <summary>
        /// 01 矩阵
        /// 给定一个由 0 和 1 组成的矩阵，找出每个元素到最近的 0 的距离。
        /// 两个相邻元素间的距离为 1 。
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int[][] UpdateMatrix(int[][] matrix)
        {
            //利用广度优先的思想，对每个元素进行广度优先遍历，找到最近的0
            if(matrix.Length == 0)
            {
                return matrix;
            }

            int[][] result = matrix;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i][j] = Distance_BFS(i, j, matrix);
                }
            }

            return result;
        }
        private int Distance_BFS(int i , int j , int[][]matrix)
        {
            if (matrix[i][j] == 0)
                return 0;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[][] direction = new int[][] { 
                new int[]{ 1,0},
                new int[]{ -1,0},
                new int[]{ 0,1},
                new int[]{ 0,-1}
            };
            Queue<int> queue = new Queue<int>();
            bool[,] visited = new bool[rows, cols];
            int result = 0;
            queue.Enqueue(i*cols+j);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int s = 0; s < size; s++)
                {
                    int cur = queue.Dequeue();
                    int x = cur / cols;
                    int y = cur % cols;
                    visited[x, y] = true;
                    if (matrix[x][y] == 0)
                    {
                        return result;
                    }
                    for (int m = 0; m < 4; m++)
                    {
                        int newX = x + direction[m][0];
                        int newY = y + direction[m][1];
                        if (InMatrix(newX, newY, matrix) && !visited[newX, newY])
                        {
                            queue.Enqueue(newX * cols + newY);
                            visited[newX, newY] = true;
                        }
                    }
                }
                
                result++;
            }
            return result;
        }
        private bool InMatrix(int x , int y , int[][] matrix)
        {
            return x >= 0 && x < matrix.Length && y >= 0 && y < matrix[0].Length;
        }
    }
}
