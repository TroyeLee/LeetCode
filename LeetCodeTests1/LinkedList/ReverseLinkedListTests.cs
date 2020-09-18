using NUnit.Framework;
using LeetCode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList.Tests
{
    [TestFixture()]
    public class ReverseLinkedListTests
    {
        [Test()]
        public void ReverseListTest()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[] { 0, 1, 2, 3 });

            ListNode result = new ReverseLinkedList().ReverseList(head);

            int[] expected = { 3,2,1,0 };

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }

        }
    }
}