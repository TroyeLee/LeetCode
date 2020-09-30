using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class IntersectionOfTwoLinkedLists
    {
        /// <summary>
        /// 相交链表
        /// 编写一个程序，找到两个单链表相交的起始节点。
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            //哈希表法
            if(headA == null || headB == null)
            {
                return null;
            }
            if(headA == headB)
            {
                return headA;
            }
            ListNode curA = headA;
            ListNode curB = headB;
            HashSet<ListNode> visited = new HashSet<ListNode>();
            visited.Add(headA);
            visited.Add(headB);
            while((curA != null && curA.next!=null) || (curB != null && curB.next != null))
            {
                curA = curA == null ? null : curA.next;
                curB = curB == null ? null : curB.next;

                if (visited.Contains(curA) || visited.Contains(curB))
                {
                    return visited.Contains(curA) ? curA : curB;
                }
                if(curA == curB)
                {
                    return curA;
                }
                if (curA != null)
                    visited.Add(curA);
                if (curB != null)
                    visited.Add(curB);
            }

            return null;
        }
        public ListNode GetIntersectionNode02(ListNode headA, ListNode headB)
        {
            //双指针法
            //路程相等思想，a走到尽头时踏上b的路程，b走到尽头时踏上a的路程 ， 相遇的地方，便必然是相交的起点 ，a -> ab -> b = meeting = b -> ab -> a
            //如果不曾相交，那么彼此的路都走过之后终究还是错过。 a -> b = null = b -> a
            if (headA == null || headB == null)
            {
                return null;
            }
            if (headA == headB)
            {
                return headA;
            }
            ListNode nodeA = headA;
            ListNode nodeB = headB;

            while(nodeA != null || nodeB != null)
            {
                nodeA = nodeA == null ? headB : nodeA.next;
                nodeB = nodeB == null ? headA : nodeB.next;

                if(nodeA == nodeB)
                {
                    return nodeA;
                }

            }


            return null;
        }
    }
}
