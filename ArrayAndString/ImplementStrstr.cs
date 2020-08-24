using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class ImplementStrstr
    {
        /// <summary>
        /// 实现 strStr()
        /// 实现 strStr() 函数。
        /// 给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置(从0开始)。如果不存在，则返回  -1。
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            int result = -1;
            if (needle.Length == 0)
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i].Equals(needle[0]))
                {
                    int index = i;
                    for (int j = 0; j < needle.Length && index < haystack.Length; j++)
                    {
                        if (haystack[index].Equals(needle[j]))
                        {
                            index++;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if ((index - i) == needle.Length)
                    {
                        result = i;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
