using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class IntersectionOfTwoArraysII
    {
        /// <summary>
        /// 两个数组的交集 II
        /// 给定两个数组，编写一个函数来计算它们的交集。
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int[]> map = new Dictionary<int, int[]>();
            IList<int> result = new List<int>();
            ArrayToMap(map, nums1, 0);
            ArrayToMap(map, nums2, 1);
            foreach (var item in map)
            {
                if (item.Value[0] != 0 && item.Value[1] != 0)
                {
                    for (int i = 0; i < Math.Min(item.Value[0],item.Value[1]); i++)
                    {
                        result.Add(item.Key);
                    }
                }
            }
            return result.ToArray();
        }

        private void ArrayToMap(Dictionary<int,int[]> map , int[] nums , int flag)
        {
            foreach (var item in nums)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, new int[2] { 0, 0 });
                }
                map[item][flag]++;
            }
        }
    }
}
