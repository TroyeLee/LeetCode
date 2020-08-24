using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class DiagonalTraverse
    {
        /// <summary>
        /// 对角线遍历
        /// 给定一个含有 M x N 个元素的矩阵（M 行，N 列），请以对角线遍历的顺序返回这个矩阵中的所有元素，对角线遍历如下图所示。
        /// 输入:
        /// [
        /// [ 1, 2, 3 ],
        /// [ 4, 5, 6 ],
        /// [ 7, 8, 9 ]
        /// ]
        /// 输出:  [1,2,4,7,5,3,6,8,9]
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            //暴力法
            if (matrix == null || matrix.Length < 1)
            {
                return new int[0];
            }
            int count = 0;
            int col = 0;
            int row = 0;
            int x = matrix[0].Length;
            int y = matrix.Length;
            IList<int> array = new List<int>();
            for (; count < x + y - 1; count++)
            {
                if (count % 2 == 0)
                {
                    row = (count < y) ? count : y - 1;
                    col = (count < y) ? 0 : count - y + 1;
                    while (row >= 0 && col < x)
                    {
                        array.Add(matrix[row][col]);
                        row--;
                        col++;
                    }
                }
                else
                {
                    row = (count < x) ? 0 : count - x + 1;
                    col = (count < x) ? count : x - 1;
                    while (row < y && col >= 0)
                    {
                        array.Add(matrix[row][col]);
                        row++;
                        col--;
                    }
                }


            }
            return array.ToArray<int>();
        }
    }
}
