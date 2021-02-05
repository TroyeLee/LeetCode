using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class GetEqualSubstringsWithinBudget
    {
        /// <summary>
        /// 1208. 尽可能使字符串相等
        /// 给你两个长度相同的字符串，s 和 t。
        /// 将 s 中的第 i 个字符变到 t 中的第 i 个字符需要 |s[i] - t[i]| 的开销（开销可能为 0），也就是两个字符的 ASCII 码值的差的绝对值。
        /// 用于变更字符串的最大预算是 maxCost。在转化字符串时，总开销应当小于等于该预算，这也意味着字符串的转化可能是不完全的。
        /// 如果你可以将 s 的子字符串转化为它在 t 中对应的子字符串，则返回可以转化的最大长度。
        /// 如果 s 中没有子字符串可以转化成 t 中对应的子字符串，则返回 0。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="maxCost"></param>
        /// <returns></returns>
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int result = 0;
            int length = s.Length;
            int surplusOfCost = maxCost;
            int currentLength = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            int leftCost, rightCost;
            while ( rightIndex < length)
            {
                rightCost = Math.Abs(t[rightIndex] - s[rightIndex]);
                if(rightCost <= surplusOfCost)
                {
                    currentLength++;
                    surplusOfCost -= rightCost;
                    result = Math.Max(result, currentLength);
                    rightIndex++;
                }
                else
                {
                    leftCost = Math.Abs(t[leftIndex] - s[leftIndex]);
                    surplusOfCost += leftCost;
                    currentLength--;
                    leftIndex++;
                }
            }
            return result;
        }
    }
}
