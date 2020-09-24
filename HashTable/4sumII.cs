using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class _4sumII
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            int result = 0;
            IDictionary<int, int> map = new Dictionary<int, int>();
            foreach (var itemA in A)
            {
                foreach (var itemB in B)
                {
                    int nums = itemA + itemB;
                    if (map.ContainsKey(nums))
                    {
                        map[nums]++;
                    }
                    else
                    {
                        map.Add(nums, 1);
                    }
                }
            }

            foreach (var itemC in C)
            {
                foreach (var itemD in D)
                {
                    int nums = 0-(itemC + itemD);
                    if (map.ContainsKey(nums))
                    {
                        result += map[nums];
                    }
                }
            }


            return result;
        }
    }
}
