using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class LongestCommonPrefixCS
    {
        /// <summary>
        /// 最长公共前缀
        /// 编写一个函数来查找字符串数组中的最长公共前缀。
        /// 如果不存在公共前缀，返回空字符串 ""。
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            if (strs.Length == 0)
            {
                return result;
            }
            int min_length = strs[0].Length;
            char c;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length <= min_length)
                    min_length = strs[i].Length;
            }
            if (min_length == 0)
            {
                return result;
            }

            for (int i = 0; i < min_length; i++)
            {
                c = strs[0][i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (!strs[j][i].Equals(c))
                    {
                        result = strs[0].Substring(0, i);

                        return result;
                    }
                }

            }
            result = strs[0].Substring(0, min_length);

            return result;
        }
    }
}
