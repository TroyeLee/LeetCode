using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class GroupAnagramsCS
    {
        /// <summary>
        /// 字母异位词分组
        /// 给定一个字符串数组，将字母异位词组合在一起。字母异位词指字母相同，但排列不同的字符串。
        /// 示例:
        ///     输入: ["eat", "tea", "tan", "ate", "nat", "bat"]
        ///     输出:
        ///     [
        ///     ["ate","eat","tea"],
        ///     ["nat","tan"],
        ///     ["bat"]
        ///     ]
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            
            IList<IList<string>> result = new List<IList<string>>();
            if(strs.Length==0|| strs == null)
            {
                return result;
            }
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                string sortString = SortString(strs[i]);
                if (map.ContainsKey(sortString))
                {
                    map[sortString].Add(strs[i]);
                }
                else
                {
                    map.Add(sortString, new List<string>() { strs[i]});
                }
            }
            foreach (var item in map)
            {
                result.Add(item.Value);
            }

            return result;
         }

        private string SortString(string str)
        {
            string result = "";
            char[] chars = str.ToCharArray();
            int min;
            for (int i = 0; i < chars.Length; i++)
            {
                min = i;
                for (int j = i+1; j < chars.Length ; j++)
                {
                    min = chars[j] < chars[min] ? j : min;
                }
                char temp = chars[i];
                chars[i] = chars[min];
                chars[min] = temp;
                result += chars[i];
            }

            return result;

        }


        /// <summary>
        /// 对26个字母分别赋予对应的质数值，因为不同的质数和必定为不同的数字结果，所以可以用来作为map的key值
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams02(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            if (strs.Length == 0 || strs == null)
            {
                return result;
            }
            Dictionary<int, IList<string>> map = new Dictionary<int, IList<string>>();
            foreach (var item in strs)
            {
                int key = BuildKey(item);
                if (map.ContainsKey(key))
                {
                    map[key].Add(item);
                }
                else
                {
                    map.Add(key, new List<string>() { item });
                }
            }
            foreach (var item in map)
            {
                result.Add(item.Value);
            }

            return result.Reverse().ToArray() ;
        }

        private int BuildKey(string str)
        {
            int result = 1;

            int[] a = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };

            foreach (var item in str)
            {
                result *= a[item - 'a'];
            }

            return result;
        }
    }
}
