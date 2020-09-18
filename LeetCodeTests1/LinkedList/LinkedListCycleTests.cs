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
    public class LinkedListCycleTests
    {
        [Test()]
        public void HasCycleTest()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body01;

            bool result = new LinkedListCycle().HasCycle(head);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void HasCycleTest02()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            bool result = new LinkedListCycle().HasCycle(head);

            bool expected = false;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void HasCycleTest03()
        {
            ListNode head = new ListNode(0);

            bool result = new LinkedListCycle().HasCycle(head);

            bool expected = false;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void HasCycleTest04()
        {
            ListNode head = new ListNode(0);
            head.next = head;

            bool result = new LinkedListCycle().HasCycle(head);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}