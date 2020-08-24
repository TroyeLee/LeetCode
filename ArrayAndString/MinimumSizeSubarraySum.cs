using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class MinimumSizeSubarraySum
    {
        /// <summary>
        /// 长度最小的子数组
        /// 给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的 连续 子数组，并返回其长度。如果不存在符合条件的子数组，返回 0。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinSubArrayLen(int s, int[] nums)
        {
            int result = nums.Length + 1;
            if (result == 0 || nums.Sum(q => q) < s)
            {
                return 0;
            }
            int i = 0, j = 0;
            int sum;
            int length;
            for (; j < nums.Length; j++)
            {
                sum = 0;
                i = j;
                while (sum < s && i < nums.Length)
                {
                    sum += nums[i];
                    i++;
                }
                if (sum >= s)
                {
                    length = i - j;
                    result = length < result ? length : result;
                }
            }
            return result;
        }
    }
}
