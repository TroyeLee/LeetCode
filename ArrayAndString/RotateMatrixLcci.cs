using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class RotateMatrixLcci
    {
        /// <summary>
        /// 旋转矩阵
        /// 给你一幅由 N × N 矩阵表示的图像，其中每个像素的大小为 4 字节。请你设计一种算法，将图像旋转 90 度。
        /// 不占用额外内存空间能否做到？
        /// </summary>
        /// <param name="matrix"></param>
        public void Rotate(int[][] matrix)
        {
            //中心对称左上->右下
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length - i - 1; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[matrix.Length - j - 1][matrix.Length - i - 1];
                    matrix[matrix.Length - j - 1][matrix.Length - i - 1] = temp;
                }
            }

            //上下翻转
            for (var i = 0; i < matrix.Length / 2; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[matrix.Length - 1 - i][j];
                    matrix[matrix.Length - 1 - i][j] = temp;
                }
            }
        }
    }
}
