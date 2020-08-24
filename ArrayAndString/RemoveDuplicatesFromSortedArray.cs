using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// 删除排序数组中的重复项
        /// 给定一个排序数组，你需要在 原地 删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
        /// 不要使用额外的数组空间，你必须在 原地 修改输入数组 并在使用 O(1) 额外空间的条件下完成。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }
            int result = 1;
            //双指针
            int left, right;
            int stap = 1;//跳过数
            for (left = 0; left < nums.Length - 1; left++)
            {
                for (right = left + stap; right < nums.Length; right++)
                {
                    if (nums[left] < nums[right])//前指针小于后指针，则后指针填充到前指针的后一位
                    {
                        nums[left + 1] = nums[right];
                        result += 1;
                        break;
                    }
                    stap++;
                }

                if (nums[left + 1] == nums[nums.Length - 1]) break; //左指针等于最后一位，则跳出
            }

            return result;
        }

    }
}
