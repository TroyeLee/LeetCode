using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class LongestPalindromicSubstring
    {
        /// <summary>
        /// 最长回文子串--暴力法
        /// 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
        /// 输入: "babad"
        /// 输出: "bab"
        /// 注意: "aba" 也是一个有效答案。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public String longestPalindrome(String s)
        {
            if (s.Length < 2)
            {
                return s;
            }
            string result = s.Substring(0, 1);
            string maxSub = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)//循环得到所有子串，并对其进行判断是否是回文
                {
                    maxSub = s.Substring(i, j - i + 1);
                    if (valid(maxSub) && maxSub.Length > result.Length)//判断得到是回文并且长度较上一个大，则替换结果，得到最长子串
                    {
                        result = maxSub;
                    }
                }
            }
            return result;
        }
        //判断回文子串
        private bool valid(string str)
        {
            int head = 0;
            int tail = str.Length - 1;
            while (head < tail)//从头和尾向中间靠拢
            {
                if (!str[head].Equals(str[tail]))//头不等于尾，则不是回文
                {
                    return false;
                }
                head++;
                tail--;
            }

            return true;
        }

        /// <summary>
        /// 最长回文子串--中心扩散法
        /// 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
        /// 输入: "babad"
        /// 输出: "bab"
        /// 注意: "aba" 也是一个有效答案。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public String LongestPalindrome02(String s)
        {
            int len = s.Length;
            if (len < 2)
            {
                return s;
            }
            string maxStr = "";
            string result = s.Substring(0, 1);

            for (int i = 0; i < len - 1; i++)//循环对每一个字母进行扩散
            {
                string oddString = CenterSpread(s, i, i); //奇数串的中心是同一个字母str[i]
                string evenString = CenterSpread(s, i, i + 1);//偶数串的中心是相邻的两个字母str[i+1]
                maxStr = oddString.Length > evenString.Length ? oddString : evenString;
                if (maxStr.Length > result.Length)//如果长度大于上一个回文串，则更换结果，得到最长子串
                {
                    result = maxStr;
                }
            }


            return result;
        }

        private string CenterSpread(string str, int head, int tail)
        {
            //中心扩散，对每一个字母（除了头和尾）进行向两边扩散
            //当head==tail时，就是奇数串
            //当head == tail - 1 时，就是偶数串
            string result = "";

            while (head >= 0 && tail < str.Length)//从中心向两边扩散
            {
                if (!str[head].Equals(str[tail]))//如果头不等于尾，则回文结束
                {
                    break;
                }
                else
                {
                    head--;
                    tail++;
                }
            }
            result = str.Substring(head + 1, tail - head - 1); //回文头和尾的位置应为 head+1 , tail -1;
            return result;
        }

    }
}
