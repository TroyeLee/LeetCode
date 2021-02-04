using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class MedianOfTwoSortedArrays
    {
        /// <summary>
        /// 给定两个大小为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的中位数。
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = 0.0;
            int indexOf1 = 0;
            int indexOf2 = 0;
            int newLength = nums1.Length + nums2.Length;
            int[] newNums = new int[newLength];
            int indexOfNew = 0;

            while(indexOf1<nums1.Length || indexOf2 < nums2.Length)
            {
                if(indexOf1 == nums1.Length)
                {
                    newNums[indexOfNew++] = nums2[indexOf2++];
                    continue;
                }
                if (indexOf2 == nums2.Length)
                {
                    newNums[indexOfNew++] = nums1[indexOf1++];
                    continue;
                }

                if (nums1[indexOf1] < nums2[indexOf2] )
                {
                    newNums[indexOfNew++] = nums1[indexOf1++];
                }
                else if (nums1[indexOf1] > nums2[indexOf2])
                {
                    newNums[indexOfNew++] = nums2[indexOf2++];
                }
                else
                {
                    newNums[indexOfNew++] = nums1[indexOf1++];
                    newNums[indexOfNew++] = nums2[indexOf2++];
                }
            }

            double medianIndex = (newLength-1) / 2.0;
            result = (newNums[(int) Math.Floor(medianIndex)] + newNums[(int)Math.Ceiling(medianIndex)]) / 2.0;


            return result;
        }
    }
}
