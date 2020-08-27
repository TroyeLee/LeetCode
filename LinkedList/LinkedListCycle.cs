using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class LinkedListCycle
    {
        /// <summary>
        /// 环形链表
        /// 给定一个链表，判断链表中是否有环。
        /// 为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。
        ///   输入：head = [3,2,0,-4], pos = 1
        ///   输出：true
        ///   解释：链表中有一个环，其尾部连接到第二个节点。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            if (head.next == null)
            {
                return false;
            }
            ListNode node_slow = head;
            ListNode node_fast = head;

            while (node_fast!=null && node_fast.next!=null)
            {
                node_slow = node_slow.next;
                node_fast = node_fast.next.next;
                if(node_fast == node_slow)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
