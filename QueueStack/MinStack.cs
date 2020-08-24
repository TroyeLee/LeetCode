using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    /// <summary>
    /// 最小栈
    /// 设计一个支持 push ，pop ，top 操作，并能在常数时间内检索到最小元素的栈。
    /// push(x) —— 将元素 x 推入栈中。
    /// pop() —— 删除栈顶的元素。
    /// top() —— 获取栈顶元素。
    /// getMin() —— 检索栈中的最小元素。
    /// </summary>
    public class MinStack
    {

        /** initialize your data structure here. */

        List<int> data;


        public MinStack()
        {
            data = new List<int>();
        }

        public void Push(int x)
        {
            data.Add(x);
        }

        public void Pop()
        {
            if (data.Count > 0)
                data.RemoveAt(data.Count - 1);
        }

        public int Top()
        {

            return data[data.Count - 1];
        }

        public int GetMin()
        {
            int min = data[0];
            for (int i = 0; i < data.Count; i++)
            {
                min = data[i] < min ? data[i] : min;
            }
            return min;
        }
    }
}
