using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class DailyTemperaturesCS
    {
        /// <summary>
        /// 每日温度
        /// 请根据每日 气温 列表，重新生成一个列表。
        /// 对应位置的输出为：要想观测到更高的气温，至少需要等待的天数。
        /// 如果气温在这之后都不会升高，请在该位置用 0 来代替。
        /// 例如，给定一个列表 temperatures = [55,38,53,81,61,93,97,32,43,78]，你的输出应该是[1, 1, 4, 2, 1, 1, 0, 0]。
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public int[] DailyTemperatures(int[] T)
        {
            //利用栈存储下标，如果最新一个元素比栈内的最后一个元素对应的元素大，则出栈一个，并计算两个下标的差值，赋值到出栈的下标，否则就进栈
            int[] results = new int[T.Length];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < T.Length; i++)
            {
                while (stack.Count > 0 && T[i] > T[stack.Peek()])
                {
                    int index = stack.Pop();
                    results[index] = i - index;
                }
                stack.Push(i);
            }


            return results;
        }
    }
}
