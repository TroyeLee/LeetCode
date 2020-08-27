using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class RemoveNthNodeFromEndOfList
    {
        /// <summary>
        /// 删除链表的倒数第N个节点
        /// 给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null)
            {
                return null;
            }
            if(n <= 0)
            {
                return head;
            }
            int index;
            int count = 0;
            ListNode node = head;
            while(node != null)
            {
                count++;
                node = node.next;
            }

            index = count - n;
            node = head;

            if(index == 0)
            {
                return head.next;
            }

            for (int i = 0; i < index - 1; i++)
            {
                node = node.next;
            }
            
            ListNode delete = node.next;
            node.next = delete.next;
            delete.next = null;

            return head;
        }
    }
}
