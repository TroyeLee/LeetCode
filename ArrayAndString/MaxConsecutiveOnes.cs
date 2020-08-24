using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class MaxConsecutiveOnes
    {
        /// <summary>
        /// 最大连续1的个数
        /// 给定一个二进制数组， 计算其中最大连续1的个数。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int i = 0, j = 0;
            for (; j < nums.Length; j++)
            {
                if (nums[j] == 1)
                {
                    if (nums[i] != 1)
                    {
                        i = j;
                    }
                }
                else
                {
                    result = (j - i > result && nums[i] == 1) ? j - i : result;
                    i = j;
                }
            }

            result = (j - i > result && nums[j - 1] == 1) ? j - i : result;

            return result;
        }
    }
}
