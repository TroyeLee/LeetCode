using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class SearchInsertPosition
    {

        /// <summary>
        /// 搜索插入位置
        /// 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
        /// 你可以假设数组中无重复元素。
        ///   输入: [1,3,5,6], 5
        ///   输出: 2
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int result = -1;
            int left_index = 0;
            int right_index = nums.Length - 1;

            int center;

            while (left_index < right_index)
            {
                center = (left_index + right_index) / 2;
                if (nums[center] > target)
                {
                    right_index = center - 1;

                }
                else if (nums[center] < target)
                {
                    left_index = center + 1;
                }
                else
                {
                    result = center;
                    break;
                }
                if (right_index < left_index)
                {
                    result = center;
                    break;
                }

            }

            if (right_index == left_index)
            {
                if (nums[right_index] >= target)
                    result = right_index;
                else
                    result = right_index + 1;
            }

            return result;
        }

    }
}
