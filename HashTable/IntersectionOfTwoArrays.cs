using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class IntersectionOfTwoArrays
    {
        /// <summary>
        /// 两个数组的交集
        /// 给定两个数组，编写一个函数来计算它们的交集。
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return new int[0];
            }
            HashSet<int> result = new HashSet<int>();
            HashSet<int> set1 = new HashSet<int>(nums1.Length >= nums2.Length ? nums2 : nums1);
            HashSet<int> set2 = new HashSet<int>(nums1.Length < nums2.Length ? nums2 : nums1);

            foreach (var item in set1)
            {
                if (set2.Contains(item) && !result.Contains(item))
                {
                    result.Add(item);
                }
            }


            return result.ToArray();
        }
    }
}
