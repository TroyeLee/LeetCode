using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class ContainsDuplicateCS
    {
        /// <summary>
        /// 存在重复元素
        /// 给定一个整数数组，判断是否存在重复元素。
        /// 如果任意一值在数组中出现至少两次，函数返回 true 。如果数组中每个元素都不相同，则返回 false 。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            if(nums==null || nums.Length <= 1)
            {
                return false;
            }
            HashSet<int> temp = new HashSet<int>();
            foreach (var item in nums)
            {
                if (temp.Contains(item))
                {
                    return true;
                }
                temp.Add(item);
            }
            return false;
        }
    }
}
