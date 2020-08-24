using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class TargetSum
    {
        /// <summary>
        /// 3.目标和
        /// 给定一个非负整数数组，a1, a2, ..., an, 和一个目标数，S。现在你有两个符号 + 和 -。对于数组中的任意一个整数，你都可以从 + 或 -中选择一个符号添加在前面。
        /// 返回可以使最终数组和为目标数 S 的所有添加符号的方法数。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public int FindTargetSumWays(int[] nums, int S)
        {
            int result = 0;

            if (nums.Length == 0)
            {
                return result;
            }

            result = DFS_SumWays(0, 0, nums, S);

            return result;
        }
        private int DFS_SumWays(int sum, int i, int[] nums, int S)
        {
            int result = 0;
            if (i == nums.Length)
            {
                if (sum == S)
                {
                    return 1;
                }
                else
                    return 0;
            }
            else
            {
                result += DFS_SumWays(sum + nums[i], i + 1, nums, S);
                result += DFS_SumWays(sum - nums[i], i + 1, nums, S);
            }
            return result;
        }
    }
}
