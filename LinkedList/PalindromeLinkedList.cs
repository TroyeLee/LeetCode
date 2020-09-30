using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class PalindromeLinkedList
    {
        /// <summary>
        /// 回文链表
        /// 请判断一个链表是否为回文链表。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            //利用栈，存放节点，出栈得到反转节点。
            //空间复杂度O(n)
            //时间复杂度O(n)
            if (head == null)
            {
                return true;
            }

            Stack<ListNode> stack = new Stack<ListNode>();

            ListNode node_positive = head;
            while (node_positive != null)
            {
                stack.Push(node_positive);
                node_positive = node_positive.next;
            }
            node_positive = head;
            ListNode node_reverse = stack.Pop();
            while (stack.Count > 0)
            {
                if(node_positive.val != node_reverse.val)
                {
                    return false;
                }
                node_reverse = stack.Pop();
                node_positive = node_positive.next;
            }

            return true;
        }

        public bool IsPalindrome02(ListNode head)
        {
            //采用双指针，慢指针边遍历，边原地反转，快指针负责走双倍，控制满指针只走一般路
            //空间复杂度O(1)
            //时间复杂度O(n)
            if (head == null || head.next == null)
            {
                return true;
            }

            ListNode pre = null;
            ListNode slow = head, fast = head;

            while(fast != null && fast.next != null)
            {
                ListNode cur = slow;
                fast = fast.next.next;
                slow = slow.next;
                cur.next = pre;
                pre = cur;
            }

            if(fast != null)
            {
                slow = slow.next;
            }

            while (slow != null)
            {
                if(slow.val != pre.val)
                {
                    return false;
                }
                slow = slow.next;
                pre = pre.next;
            }

            return true;
        }
    }
}
