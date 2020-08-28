using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class ReverseLinkedList
    {
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
