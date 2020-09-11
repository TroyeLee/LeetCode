using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class IsomorphicStrings
    {
        /// <summary>
        /// 同构字符串
        /// 给定两个字符串 s 和 t，判断它们是否是同构的。
        /// 如果 s 中的字符可以被替换得到 t ，那么这两个字符串是同构的。
        /// 所有出现的字符都必须用另一个字符替换，同时保留字符的顺序。两个字符不能映射到同一个字符上，但字符可以映射自己本身。
        ///     输入: s = "egg", t = "add"
        ///     输出: true
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsIsomorphic(string s, string t)
        {
            int length = s.Length;
            if (length != t.Length)
            {
                return false;
            }
            IDictionary<char, char> map = new Dictionary<char, char>();
            for (int i = 0; i < length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if(map[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                if (map.Any(u=>u.Value == t[i]))
                {
                    if(map.FirstOrDefault(u => u.Value == t[i]).Key!=s[i])
                        return false;
                }
                else
                {
                    map.Add(s[i], t[i]);
                }
            }
            return true;
        }



        public bool IsIsomorphic02(string s, string t)
        {
            return IsIsomorphicHelper(s,t)&&IsIsomorphicHelper(t,s);
        }
        private bool IsIsomorphicHelper(string s, string t)
        {
            int length = s.Length;
            if (length != t.Length)
            {
                return false;
            }
            IDictionary<char, char> map = new Dictionary<char, char>();
            for (int i = 0; i < length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (map[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    map.Add(s[i], t[i]);
                }
            }
            return true;
        }
    }
}
