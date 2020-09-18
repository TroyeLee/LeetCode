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
    public class LinkedListCycleIITests
    {
        [Test()]
        public void DetectCycleTest()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body01;

            ListNode result = new LinkedListCycleII().DetectCycle(head);

            ListNode expected = body01;

            Assert.AreEqual(expected,result);
        }
        [Test()]
        public void DetectCycleTest02()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            ListNode result = new LinkedListCycleII().DetectCycle(head);

            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void DetectCycleTest03()
        {
            ListNode head = new ListNode(0);
            head.next = head;

            ListNode result = new LinkedListCycleII().DetectCycle(head);

            ListNode expected = head;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void DetectCycleTest04()
        {
            ListNode head = null;

            ListNode result = new LinkedListCycleII().DetectCycle(head);

            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void DetectCycleTest05()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body01;

            ListNode result = new LinkedListCycleII().DetectCycle02(head);

            ListNode expected = body01;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void DetectCycleTest06()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            ListNode result = new LinkedListCycleII().DetectCycle02(head);

            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void DetectCycleTest07()
        {
            ListNode head = new ListNode(0);
            head.next = head;

            ListNode result = new LinkedListCycleII().DetectCycle02(head);

            ListNode expected = head;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void DetectCycleTest08()
        {
            ListNode head = null;

            ListNode result = new LinkedListCycleII().DetectCycle02(head);

            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
    }
}