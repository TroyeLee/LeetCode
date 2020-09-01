using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class AddTwoNumbersCS
    {
        /// <summary>
        /// 两数相加
        /// 给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
        /// 如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
        /// 您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
        ///     输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
        ///     输出：7 -> 0 -> 8
        ///     原因：342 + 465 = 807
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1 == null ? l2 : l1;
            }
            ListNode cur = new ListNode(-1);
            ListNode result = cur;
            int calculate ;
            int over = 0;
            while(over > 0 || l1!=null || l2 != null )
            {
                int num1 = l1 == null ? 0 : l1.val;
                int num2 = l2 == null ? 0 : l2.val;
                calculate = (num1+num2)+over;
                over = calculate / 10;
                calculate = calculate % 10;
                cur.next = new ListNode(calculate);
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
                cur = cur.next;
            }

            return result.next;
        }
    }
}
