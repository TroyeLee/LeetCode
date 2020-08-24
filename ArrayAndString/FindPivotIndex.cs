using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class FindPivotIndex
    {
        /// <summary>
        /// 寻找数组的中心索引
        /// 给定一个整数类型的数组 nums，请编写一个能够返回数组 “中心索引” 的方法。
        /// 我们是这样定义数组 中心索引 的：数组中心索引的左侧所有元素相加的和等于右侧所有元素相加的和。
        /// 如果数组不存在中心索引，那么我们应该返回 -1。如果数组有多个中心索引，那么我们应该返回最靠近左边的那一个。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int PivotIndex(int[] nums)
        {
            int result = -1;
            int sumofLeft = 0;
            int sumofRight = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sumofRight += nums[j];
                }
                if (sumofLeft == sumofRight)
                {
                    result = i;
                    break;
                }
                sumofLeft += nums[i];
                sumofRight = 0;
            }


            return result;
        }
    }
}
