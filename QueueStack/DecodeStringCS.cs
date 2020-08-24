using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class DecodeStringCS
    {
        /// <summary>
        /// 字符串解码
        /// 给定一个经过编码的字符串，返回它解码后的字符串。
        /// 编码规则为: k[encoded_string]，表示其中方括号内部的 encoded_string 正好重复 k 次。注意 k 保证为正整数。
        /// 你可以认为输入字符串总是有效的；输入字符串中没有额外的空格，且输入的方括号总是符合格式要求的。
        /// 此外，你可以认为原始数据不包含数字，所有的数字只表示重复的次数 k ，例如不会出现像 3a 或 2[4] 的输入。
        ///     输入：s = "3[a]2[bc]"
        ///     输出："aaabcbc"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string DecodeString(string s)
        {
            string result = "";

            Stack<string> stack = new Stack<string>();
            //不是“]”就进栈，遇到“]”则寻找栈中的字符、数字，并组建字符串，然后进栈。
            for (int i = 0; i < s.Length; i++)
            {
                string c = s[i] + "";
                if (!c.Equals("]"))
                {
                    stack.Push(c);
                }
                else
                {
                    string sub = GetString(stack);
                    int num = GetNums(stack);
                    string decodeS = BuildString(num, sub);
                    stack.Push(decodeS);
                }
            }
            //从栈中的字符串构成解码后的字符串
            while (stack.Count > 0)
            {
                result = stack.Pop() + result;
            }
            return result;
        }
        private string GetString(Stack<string> stack)
        {
            string result = "";
            string cur = stack.Pop();
            while (!cur.Equals("["))
            {
                result = cur + result;
                cur = stack.Pop();
            }
            return result;
        }
        private int GetNums(Stack<string> stack)
        {
            int result = 1;
            string nums = "";
            string cur = stack.Peek();
            while (stack.Count > 0 && char.IsDigit(cur[0]))
            {
                cur = stack.Pop();
                nums = cur + nums;
                cur = stack.Count > 0 ? stack.Peek() : "";
            }
            if (nums.Length > 0)
            {
                result = Convert.ToInt32(nums);
            }
            return result;
        }

        private string BuildString(int k, string s)
        {
            StringBuilder result = new StringBuilder();

            while (k > 0)
            {
                result.Append(s);
                k--;
            }

            return result.ToString();
        }
    }
}
