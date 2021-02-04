using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class MaximumAverageSubarrayI
    {
        /// <summary>
        /// 643. 子数组最大平均数 I
        /// 给定 n 个整数，找出平均数最大且长度为 k 的连续子数组，并输出该最大平均数。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public double FindMaxAverage(int[] nums, int k)
        {
            double maxAverage=0.0;
            if (k > nums.Length)
            {
                return maxAverage;
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int count = 0;
            double currentAverage = 0.0;
            int sum = 0;
            for (; rightIndex < nums.Length; rightIndex++)
            {
                sum += nums[rightIndex];
                count = rightIndex - leftIndex + 1;
                if ( count == k)
                {
                    currentAverage =  (double) sum / k;
                    if (maxAverage < currentAverage || leftIndex == 0)
                    {
                        maxAverage = currentAverage;
                    }
                    sum -= nums[leftIndex];
                    leftIndex++;
                }
            }


            return maxAverage;
        }


    }
}
