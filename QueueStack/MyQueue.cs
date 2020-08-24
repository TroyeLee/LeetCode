using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    /// <summary>
    ///用栈实现队列
    ///  使用栈实现队列的下列操作：
    ///  push(x) -- 将一个元素放入队列的尾部。
    ///  pop() -- 从队列首部移除元素。
    ///  peek() -- 返回队列首部的元素。
    ///  empty() -- 返回队列是否为空。
    /// </summary>
    public class MyQueue
    {

        /** Initialize your data structure here. */

        private Stack<int> data;
        private Stack<int> data_revers;
        public MyQueue()
        {
            data = new Stack<int>();
            data_revers = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            data.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            while (data.Count > 0)
            {
                data_revers.Push(data.Pop());
            }
            int result = data_revers.Pop();
            while (data_revers.Count > 0)
            {
                data.Push(data_revers.Pop());
            }
            return result;
        }

        /** Get the front element. */
        public int Peek()
        {
            while (data.Count > 0)
            {
                data_revers.Push(data.Pop());
            }
            int result = data_revers.Peek();
            while (data_revers.Count > 0)
            {
                data.Push(data_revers.Pop());
            }
            return result;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return data.Count == 0;
        }
    }
}
