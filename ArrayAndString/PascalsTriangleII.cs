using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class PascalsTriangleII
    {
        /// <summary>
        /// 杨辉三角II
        /// 给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> result = new List<int>();
            IList<IList<int>> temp = new List<IList<int>>();
            for (int i = 0; i < rowIndex + 1; i++)
            {
                result = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    int t = (j == 0 || j == i) ? 1 : temp[i - 1][j - 1] + temp[i - 1][j];//生成树
                    result.Add(t);
                }
                //轮到目标行
                if (i == rowIndex)
                {
                    return result;
                }
                temp.Add(result);

            }

            return result;
        }
    }
}
