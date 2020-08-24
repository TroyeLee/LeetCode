using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class RemoveElementCS
    {
        /// <summary>
        /// 移除元素
        /// 给你一个数组 nums 和一个值 val，你需要 原地 移除所有数值等于 val 的元素，并返回移除后数组的新长度。
        /// 不要使用额外的数组空间，你必须仅使用 O(1) 额外空间并 原地 修改输入数组。
        /// 元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[result] = nums[i];
                if (nums[i] != val)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
