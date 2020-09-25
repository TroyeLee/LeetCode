using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 前 K 个高频元素
    /// 给定一个非空的整数数组，返回其中出现频率前 k 高的元素。
    /// 示例 1:
    /// 输入: nums = [1,1,1,2,2,3], k = 2
    /// 输出: [1,2]
    /// </summary>
    public class TopKFrequentElements
    {
        
        public int[] TopKFrequent(int[] nums, int k)
        {
            //先获取各个数字出现频率，然后利用列表数组对其进行排序，以出现频率为索引，出现相同次数的放到同一个list中，最后对这个数组反序输出。
            IList<int> result = new List<int>();
            IDictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            IList<int>[] temp = new List<int>[nums.Length+1];
            foreach (var item in map)
            {
                if(temp[item.Value]==null)
                    temp[item.Value] = new List<int>();
                temp[item.Value].Add(item.Key);
            }
            int count = 0;
            for (int i = temp.Length-1; i >= 0; i--)
            {
                if (temp[i] == null)
                {
                    continue;
                }
                else
                {
                    foreach (var item in temp[i])
                    {
                        result.Add(item);
                        count++;
                        if (count == k)
                        {
                            return result.ToArray();
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
