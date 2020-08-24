using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class MoveZeroesCS
    {
        /// <summary>
        /// 移动零
        /// 给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {

            if (nums == null || nums.Length == 0)
            {
                return;
            }

            //快慢指针法，当快指针不等于0，则赋值给慢指针。
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    nums[slow++] = nums[fast];
                }
            }
            for (int i = slow; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
