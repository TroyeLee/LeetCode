using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class ReverseWordsInAStringIII
    {
        /// <summary>
        /// 反转单词
        /// 给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            StringBuilder result = new StringBuilder();
            //分割
            string[] words = s.Split(' ');

            StringBuilder word = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                word.Clear();
                //反转
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    word.Append((words[i])[j]);
                }
                //添加
                result.Append(word + " ");
            }

            return result.ToString().Trim();
        }
    }
}
