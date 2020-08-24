using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class FindMinimumInRotatedSortedArray
    {
        /// <summary>
        /// 寻找旋转排序数组中的最小值
        /// 假设按照升序排序的数组在预先未知的某个点上进行了旋转。
        /// (例如，数组[0, 1, 2, 4, 5, 6, 7] 可能变为[4, 5, 6, 7, 0, 1, 2] )。
        /// 请找出其中最小的元素。
        /// 你可以假设数组中不存在重复元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMin(int[] nums)
        {
            /*暴力法*/
            //int result = nums[0];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] < nums[0])
            //    {
            //        return nums[i];
            //    }
            //}

            //return result;

            /*二分法*/
            int right = nums.Length - 1;
            int left = 0;
            int mid;
            while (left < right)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return nums[left];

        }
    }
}
