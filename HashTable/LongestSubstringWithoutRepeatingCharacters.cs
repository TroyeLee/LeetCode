using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 无重复字符的最长子串
    /// 给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            if (s.Length == 0 || s == null)
            {
                return 0;
            }
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (set.Contains(s[j]))
                    {
                        break;
                    }
                    else
                    {
                        set.Add(s[j]);
                    }
                }

                result = result > set.Count() ? result : set.Count();
                set.Clear();
            }

            return result;
        }

        public int LengthOfLongestSubstring02(string s)
        {
            int result = 0;
            if (s.Length == 0 || s == null)
            {
                return 0;
            }
            Queue<char> set = new Queue<char>();
            for (int i = 0; i < s.Length; )
            {
                if (set.Contains(s[i]))
                {
                    result = Math.Max(result, set.Count());
                    set.Dequeue();
                }
                else
                {
                    set.Enqueue(s[i]);
                    i++;
                }
            }
            result = Math.Max(result, set.Count());
            return result;
        }
    }
}
