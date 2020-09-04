using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class SingleNumberCS
    {
        /// <summary>
        /// 只出现一次的数字
        /// 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            int result = dic.FirstOrDefault(u => u.Value==1 ).Key;
            dic.Clear();
            
            return result;
        }

        public int SingleNumber02(int[] nums)
        {
            //采用异或运算，相同的数值异或结果为0，因为题目要求除结果外，其余全部元素都为两个，所以完全可以使用异或，a^b^a = a^a^b = b^a^a = b ,就666
            int result = 0;
            foreach (var item in nums)
            {
                result ^= item;
            }

            return result;
        }
    }
}
