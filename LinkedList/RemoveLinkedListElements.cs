using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class RemoveLinkedListElements
    {
        /// <summary>
        /// 移除链表元素
        /// 删除链表中等于给定值 val 的所有节点。
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements(ListNode head, int val)
        {
            //先判断头是不是符合删除节点，删除头部节点，然后判断剩余部位是否符合删除节点
            if(head == null)
            {
                return null;
            }
            ListNode fast = head;
            ListNode result = head;
            while (result != null && result.val == val)
            {
                result = result.next;
            }
            while (fast.next != null)
            {
                if(fast.next.val == val)
                {
                    fast.next = fast.next.next;
                    continue;
                }
                fast = fast.next;
            }

            return result;
        }
        public ListNode RemoveElements02(ListNode head, int val)
        {
            //哨兵法
            /*通过哨兵节点去解决它头部问题，
             * 哨兵节点广泛应用于树和链表中，如伪头、伪尾、标记等，它们是纯功能的，
             * 通常不保存任何数据，其主要目的是使链表标准化，如使链表永不为空、永不无头、简化插入和删除。*/
            if (head == null)
            {
                return null;
            }
            ListNode sentry = new ListNode(0);//哨兵
            sentry.next = head;
            ListNode curNode = sentry;
            while (curNode.next != null)
            {
                if (curNode.next.val == val)
                {
                    curNode.next = curNode.next.next;
                    continue;
                }
                curNode = curNode.next;
            }

            return sentry.next;
        }
    }
}
