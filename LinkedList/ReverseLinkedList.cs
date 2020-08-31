using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class ReverseLinkedList
    {
        /// <summary>
        /// 反转链表
        /// 反转一个单链表。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode curNode = head;
            ListNode oldHead = head;
            ListNode newHead = head;
            while (curNode.next != null)
            {
                newHead = curNode.next;
                curNode.next = newHead.next;
                newHead.next = oldHead;
                oldHead = newHead;
            }

            return newHead;
        }
    }
}
