using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class MyCircularQueue
    {

        private int[] data;
        private int head;
        private int tail;
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            data = new int[k];
            head = 0;
            tail = 0;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            data[tail % data.Length] = value;
            tail += 1;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            head += 1;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return data[head % data.Length];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return data[(tail - 1) % data.Length];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return head == tail;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {

            return (tail - head) == data.Length;
        }
    }
}
