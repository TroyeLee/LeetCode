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
    public class OddEvenLinkedListTests
    {
        [Test()]
        public void OddEvenListTest()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            ListNode body04 = new ListNode(4);
            ListNode body05 = new ListNode(5);
            ListNode body06 = new ListNode(6);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new OddEvenLinkedList().OddEvenList(head);
            Assert.AreEqual(head, result);
        }
        [Test()]
        public void OddEvenListTest01()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            ListNode body04 = new ListNode(4);
            ListNode body05 = new ListNode(5);
            ListNode body06 = new ListNode(6);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new OddEvenLinkedList().OddEvenList(body01);
            Assert.AreEqual(body01, result);
        }
    }
}