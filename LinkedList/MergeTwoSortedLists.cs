using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class MergeTwoSortedLists
    {
        /// <summary>
        /// 合并两个有序链表
        /// 将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1 == null ? l2 : l1;
            }

            ListNode result = new ListNode(-1);
            ListNode prev = result;

            //上上下下地遍历，谁小就next谁
            while(l1!=null && l2!= null)
            {
                if(l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            prev.next = l1 == null ? l2 : l1;

            return result.next;
        }
    }
}
