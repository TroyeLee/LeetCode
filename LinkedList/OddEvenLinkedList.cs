using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class OddEvenLinkedList
    {
        /// <summary>
        /// 奇偶链表
        /// 给定一个单链表，把所有的奇数节点和偶数节点分别排在一起。请注意，这里的奇数节点和偶数节点指的是节点编号的奇偶性，而不是节点的值的奇偶性。
        /// 请尝试使用原地算法完成。你的算法的空间复杂度应为 O(1)，时间复杂度应为 O(nodes)，nodes 为节点总数。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode index = head;
            ListNode move = head.next;
            ListNode EvenHead = head.next;

            while(move != null && move.next != null) { 
                    index.next = move.next;
                    move.next = move.next.next;
                    index.next.next = EvenHead;
                    move = move.next;
                    index = index.next;
            }

            return head;

        }
        //空间复杂度O(1),时间复杂度O(n)
    }
}
