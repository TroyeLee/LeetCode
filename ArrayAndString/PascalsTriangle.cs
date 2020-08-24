using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class PascalsTriangle
    {
        /// <summary>
        /// 杨辉三角
        /// 给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                IList<int> temp = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    int t = (j == 0 || j == i) ? 1 : result[i - 1][j - 1] + result[i - 1][j];//生成值
                    temp.Add(t);
                }
                result.Add(temp);
            }

            return result;
        }

    }
}
