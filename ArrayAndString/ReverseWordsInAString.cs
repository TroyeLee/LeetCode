using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class ReverseWordsInAString
    {
        /// <summary>
        /// 翻转字符串里的单词
        /// 给定一个字符串，逐个翻转字符串中的每个单词。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            if (s.Length == 0)
            {
                return "";
            }
            string[] words = s.Trim().Split(' ');
            if (words.Length == 0)
            {
                return "";
            }
            string result = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += string.IsNullOrEmpty(words[i]) ? "" : words[i] + " ";
            }
            result = result.TrimEnd();
            return result;
        }
    }
}
