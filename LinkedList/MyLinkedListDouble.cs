using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 设计链表
    /// 设计链表的实现。您可以选择使用单链表或双链表。单链表中的节点应该具有两个属性：val 和 next。val 是当前节点的值，next 是指向下一个节点的指针/引用。
    /// 如果要使用双向链表，则还需要一个属性 prev 以指示链表中的上一个节点。假设链表中的所有节点都是 0-index 的。
    /// </summary>
    public class MyLinkedListDouble
    {
        //双链表式
        //两个哨兵，一头一尾

        /** Initialize your data structure here. */
        public class MyNode_double
        {
            public int val;
            public MyNode_double next;
            public MyNode_double prev;
            public MyNode_double(int data)
            {
                val = data;
                next = null;
                prev = null;
            }
        }
        private MyNode_double  head , tail;
        private int Count;
        
        public MyLinkedListDouble()
        {
            head = new MyNode_double(0);
            tail = new MyNode_double(0);
            head.next = tail;
            tail.prev = head;
            Count = 0;
        }

        /** Get the value of the index-th MyNode_double in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if(index >= Count)
            {
                return -1;
            }
            int i = 0;
            MyNode_double cur = head.next;
            while (cur != null)
            {
                if(i == index)
                {
                    return cur.val;
                }
                cur = cur.next;
                i++;
            }
            return -1;
        }

        /** Add a MyNode_double of value val before the first element of the linked list. After the insertion, the new MyNode_double will be the first MyNode_double of the linked list. */
        public void AddAtHead(int val)
        {
            head.next.prev = new MyNode_double(val);
            head.next.prev.next = head.next;

            head.next = head.next.prev;
            head.next.prev = head;

            Count++;
        }

        /** Append a MyNode_double of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            tail.prev.next = new MyNode_double(val);
            tail.prev.next.prev = tail.prev;

            tail.prev = tail.prev.next;
            tail.prev.next = tail;

            Count++;
        }

        /** Add a MyNode_double of value val before the index-th MyNode_double in the linked list. If index equals to the length of linked list, the MyNode_double will be appended to the end of linked list. If index is greater than the length, the MyNode_double will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index >= Count)
            {
                AddAtTail(val);
                return;
            }
            if (index <= 0)
            {
                AddAtHead(val);
                return;
            }
            int i = 0;

            MyNode_double cur = head;
            while (i < index )
            {
                cur = cur.next;
                i++;
            }

            cur.next.prev = new MyNode_double(val);
            cur.next.prev.next = cur.next;

            cur.next = cur.next.prev;
            cur.next.prev = cur;
            Count++;
        }

        /** Delete the index-th MyNode_double in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (Count == 0)
            {
                return;
            }
            if (index >= Count)
            {
                return;
            }
            int i = 0;
            MyNode_double cur = head;
            while (i < index )
            {
                cur = cur.next;
                i++;
            }
            cur.next = cur.next.next;
            if (cur.next != null)
                cur.next.prev = cur;
            Count--;
        }
    }
}
