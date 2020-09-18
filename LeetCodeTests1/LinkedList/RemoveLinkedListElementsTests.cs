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
    public class RemoveLinkedListElementsTests
    {
        [Test()]
        public void RemoveElementsTest()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(2);
            //head.next = body01;
            body01.next = body02;
            body02.next = body03;

            ListNode result = new RemoveLinkedListElements().RemoveElements(head, 0);
        }

        [Test()]
        public void RemoveElementsTest02()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(2);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            ListNode result = new RemoveLinkedListElements().RemoveElements02(head, 2);
        }
        [Test()]
        public void RemoveElementsTest03()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(2);
            //head.next = body01;
            body01.next = body02;
            body02.next = body03;

            ListNode result = new RemoveLinkedListElements().RemoveElements02(head, 0);

        }
    }
}