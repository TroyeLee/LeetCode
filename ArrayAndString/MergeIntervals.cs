using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class MergeIntervals
    {
        /// <summary>
        /// 合并区间
        /// 给出一个区间的集合，请合并所有重叠的区间。
        ///   输入: intervals = [[1,3],[2,6],[8,10],[15,18]]
        ///   输出: [[1,6],[8,10],[15,18]]
        ///   解释: 区间[1, 3] 和[2, 6] 重叠, 将它们合并为[1, 6].
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] Merge(int[][] intervals)
        {
            int[][] result;

            IList<int[]> temp = new List<int[]>();
            if (intervals.Length == 0)
            {
                return intervals;
            }

            /*基于每个区间左边界完成数组排序，保证区间左边界越小的越靠近左边。*/
            intervals = intervals.OrderBy(p => p[0]).ToArray();

            int head;
            int tail;
            for (int i = 0; i < intervals.Length; i++)
            {
                head = intervals[i][0];
                tail = intervals[i][1];
                for (int j = i; j < intervals.Length; j++)
                {
                    if (j == (intervals.Length - 1))
                    {
                        i = j;
                        break;
                    }
                    else
                    {
                        if (tail >= intervals[j + 1][0] && tail <= intervals[j + 1][1])
                        {
                            tail = intervals[j + 1][1];

                        }
                        else if (tail >= intervals[j + 1][1])
                        {

                        }
                        else
                        {
                            i = j;
                            break;
                        }
                    }
                }
                temp.Add(new int[] { head, tail });

            }

            result = temp.ToArray();

            return result;
        }
    }
}
