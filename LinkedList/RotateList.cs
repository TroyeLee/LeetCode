using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class RotateList
    {
        /// <summary>
        /// 旋转链表
        /// 给定一个链表，旋转链表，将链表每个节点向右移动 k 个位置，其中 k 是非负数。
        ///   输入: 1->2->3->4->5->NULL, k = 2
        ///   输出: 4->5->1->2->3->NULL
        ///   解释:
        ///   向右旋转 1 步: 5->1->2->3->4->NULL
        ///   向右旋转 2 步: 4->5->1->2->3->NULL
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public ListNode RotateRight(ListNode head, int k)
        {
            //利用栈+指针
            if(head == null || k==0)
            {
                return head;
            }
            ListNode result = new ListNode(-1);
            ListNode curNode = head;
            Stack<ListNode> stack = new Stack<ListNode>();
            while (curNode != null)
            {
                stack.Push(curNode);
                curNode = curNode.next;
            }
            int count = stack.Count;

            int times = k % count;
            if(times == 0)
            {
                return head;
            }
            stack.Peek().next = head;
            while (times > 0)
            {
                curNode = stack.Pop();
                times--;
            }
            result.next = curNode;
            stack.Peek().next = null;


            return result.next;
        }

        public ListNode RotateRight02(ListNode head, int k)
        {
            //利用指针
            if (head == null || k == 0)
            {
                return head;
            }
            ListNode curNode = head;
            ListNode endNode = head ;
            int count = 0;
            while (curNode != null)
            {
                endNode = curNode;
                curNode = curNode.next;
                count++;
            }

            int times = k % count;
            if (times == 0)
            {
                return head;
            }
            endNode.next = head;
            int index = count - times;
            curNode = head;
            while (index > 0)
            {
                endNode = curNode;
                curNode = curNode.next;
                index--;
            }

            endNode.next = null;

            return curNode ;
        }
    }
}
