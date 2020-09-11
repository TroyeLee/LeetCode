using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class TwoSumCs
    {
        /// <summary>
        /// 两数之和
        /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        /// 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
        ///   给定 nums = [2, 7, 11, 15], target = 9
        ///   因为 nums[0] + nums[1] = 2 + 7 = 9
        ///   所以返回[0, 1]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            
            int[] result = new int[2]; 
            if (nums.Length == 0 || !nums.Any())
            {
                return result;
             }
            IDictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                foreach (var item in map)//傻逼循环map，计算是否等于target
                {
                    int sum = item.Value + nums[i];
                    if (sum == target)
                    {
                        result[0] = item.Key;
                        result[1] = i;
                        return result;
                    }
                }
                map.Add(i,nums[i]);
            }

            return result;
        }
        //时间复杂度O(n^2)
        //空间复杂度O(n)

        public int[] TwoSum02(int[] nums, int target)
        {
            int[] result = new int[2];
            if (nums.Length == 0 || !nums.Any())
            {
                return result;
            }
            IDictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int subtract = target - nums[i];//判断是否存在他们的商的结果
                if (map.ContainsKey(subtract))
                {
                    result[0] = map[subtract];
                    result[1] = i;
                    return result;
                }
                if(!map.ContainsKey(nums[i]))
                    map.Add(nums[i],i);
            }

            return result;
        }
        //时间复杂度O(n)
        //空间复杂度O(n)
    }

}
