using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class FirstUniqueCharacterInAString
    {
        /// <summary>
        /// 字符串中的第一个唯一字符
        /// 给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqChar(string s)
        {
            int result = -1;
            if(s.Length == 0 || s == null)
            {
                return result;
            }
            Dictionary<char, int[]> map = new Dictionary<char, int[]>();
            for (int i = 0; i < s.Length; i++)
            {
                char item = s[i];
                if (map.ContainsKey(item))
                {
                    map[item][1]++;
                }
                else
                {
                    map.Add(item, new int[] {i,1 });
                }
            }
            foreach (var item in map)
            {
                if (item.Value[1] == 1)
                {
                    return item.Value[0];
                }
            }

            return result;
        }
    }
}
