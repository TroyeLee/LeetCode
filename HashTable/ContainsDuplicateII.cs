using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class ContainsDuplicateII
    {
        /// <summary>
        /// 存在重复元素 II
        /// 给定一个整数数组和一个整数 k，判断数组中是否存在两个不同的索引 i 和 j，使得 nums [i] = nums [j]，并且 i 和 j 的差的 绝对值 至多为 k。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length == 0 || nums == null)
            {
                return false;
            }
            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                int differ = k + i;
                if (map.ContainsKey(nums[i]))
                {
                    if (map[nums[i]].Any(u => u >= i))
                    {
                        return true;
                    }
                    else
                    {
                        map[nums[i]].Add(differ);
                    }
                }
                else
                {
                    map.Add(nums[i], new HashSet<int>() { differ });
                }

            }

            return false;
        }

        public bool ContainsNearbyDuplicate02(int[] nums, int k)
        {
            if (nums.Length == 0 || nums == null)
            {
                return false;
            }
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    int index = map[nums[i]];
                    int differ = Math.Abs(i - index);
                    if(differ <= k)
                    {
                        return true;
                    }
                    map[nums[i]] = i;
                }
                else
                {
                    map.Add(nums[i], i);
                }

            }

            return false;
        }
    }
}
