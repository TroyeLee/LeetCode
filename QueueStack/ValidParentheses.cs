using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class ValidParentheses
    {

        /// <summary>
        /// 有效的括号
        /// 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
        /// 有效字符串需满足：
        ///   1.左括号必须用相同类型的右括号闭合。
        ///   2左括号必须以正确的顺序闭合。
        /// 注意空字符串可被认为是有效字符串。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            //长度为奇数必为无效字符串
            if (s.Length % 2 == 1)
            {
                return false;
            }
            //空字符串被认为是有效字符串
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            //int index = 0;
            string left = "({[";
            string stack = "";
            //利用栈的思想，对符号进行匹配
            //第一个符号进栈，并判断是否左括号,若不是，则不是有效字符串
            char tailOfStack = s[0];
            if (!left.Contains(tailOfStack.ToString()))
            {
                return false;
            }
            stack += tailOfStack;
            //遍历字符串
            for (int i = 1; i < s.Length; i++)
            {
                //如果当前字符s[i]为右括号，与栈尾进行匹配是否相同类型
                if (!left.Contains(s[i].ToString()))
                {
                    tailOfStack = stack[stack.Length - 1];
                    //类型相同，则栈尾出栈，类型不相同，为无效字符串
                    if (Matching(tailOfStack, s[i]))
                    {
                        stack = stack.Remove(stack.Length - 1, 1);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    //字符进栈
                    stack += s[i];
                }

            }
            //检查是否全部出栈
            return (stack.Length == 0);


        }

        private bool Matching(char tailOfStack, char current)
        {
            switch (current)
            {
                case ')':
                    if (tailOfStack == '(')
                    {
                        return true;
                    }
                    else
                        return false;
                    break;
                case ']':
                    if (tailOfStack == '[')
                    {
                        return true;
                    }
                    else
                        return false;
                    break;
                case '}':
                    if (tailOfStack == '{')
                    {
                        return true;
                    }
                    else
                        return false;
                    break;
            }
            return true;
        }
    }
}
