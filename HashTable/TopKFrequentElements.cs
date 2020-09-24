using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            HashSet<int> result = new HashSet<int>();
            IDictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                    if(map[item]>k && !result.Contains(item))
                    {
                        result.Add(item);
                    }
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            

            return result.ToArray();
        }
    }
}
