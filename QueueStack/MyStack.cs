using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    /// <summary>
    /// 用队列实现栈
    /// 使用队列实现栈的下列操作：
    /// push(x) -- 元素 x 入栈
    /// pop() -- 移除栈顶元素
    /// top() -- 获取栈顶元素
    /// empty() -- 返回栈是否为空
    /// </summary>
    public class MyStack
    {

        /** Initialize your data structure here. */
        private Queue<int> data;

        public MyStack()
        {
            data = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            //只用一条队列，每次出栈，都对队列重新排队，直到队尾出队。
            data.Enqueue(x);
            int size = data.Count;
            while (size > 1)
            {
                data.Enqueue(data.Dequeue());
                size--;
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return data.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return data.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return data.Count == 0;
        }
    }
}
