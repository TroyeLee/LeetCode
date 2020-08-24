using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class EvaluateReversePolishNotation
    {
        /// <summary>
        /// 逆波兰表达式求值
        /// 根据 逆波兰表示法，求表达式的值。
        /// 有效的运算符包括 +, -, *, / 。每个运算对象可以是整数，也可以是另一个逆波兰表达式。
        /// 输入: ["2", "1", "+", "3", "*"]
        /// 输出: 9
        /// 解释: 该算式转化为常见的中缀算术表达式为：((2 + 1) * 3) = 9
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public int EvalRPN(string[] tokens)
        {
            int result = Convert.ToInt32(tokens[0]);

            Stack<string> stack = new Stack<string>();
            string signs = "+-*/";

            for (int i = 0; i < tokens.Length; i++)
            {
                //如果是符号，出栈两个，并计算，并把计算结果进栈
                if (signs.Contains(tokens[i]))
                {
                    string b = stack.Pop();
                    string a = stack.Pop();
                    result = Calculate(a, b, tokens[i]);
                    stack.Push(result.ToString());
                }
                //否则就进栈
                else
                    stack.Push(tokens[i]);
            }


            return result;
        }

        //计算
        private int Calculate(string a, string b, string sign)
        {
            int result = 0;
            int numA = Convert.ToInt32(a);
            int numB = Convert.ToInt32(b);
            char signs = Convert.ToChar(sign);
            switch (signs)
            {
                case '*': result = numA * numB; break;
                case '/': result = numA / numB; break;
                case '+': result = numA + numB; break;
                case '-': result = numA - numB; break;
            }

            return result;

        }
    }
}
