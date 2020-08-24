using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class ZeroMatrixLcci
    {
        /// <summary>
        /// 零矩阵
        /// 编写一种算法，若M × N矩阵中某个元素为0，则将其所在的行与列清零。
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[][] matrix)
        {
            if (matrix.Length != 0)
            {
                //记录存在0的行和列。
                IList<int> row = new List<int>();
                IList<int> col = new List<int>();
                int length = matrix[0].Length;
                int height = matrix.Length;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (matrix[i][j] == 0)
                        {
                            if (!row.Contains(i))
                                row.Add(i);
                            if (!col.Contains(j))
                                col.Add(j);
                        }
                    }
                }
                //把存在0的行列都设置为0
                foreach (var rowItem in row)
                {
                    matrix[rowItem] = new int[length];
                }

                foreach (var colItem in col)
                {
                    for (int i = 0; i < height; i++)
                    {
                        matrix[i][colItem] = 0;
                    }
                }
            }


        }
    }
}
