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
    public class RemoveNthNodeFromEndOfListTests
    {
        [Test()]
        public void RemoveNthFromEndTest()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            int index = 2;

            ListNode result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, index);

            
        }
        [Test()]
        public void RemoveNthFromEndTest02()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            int index = 1;

            ListNode result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, index);


        }

        [Test()]
        public void RemoveNthFromEndTest03()
        {
            ListNode head = new ListNode(0);

            int index = 1;

            ListNode result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, index);


        }

        [Test()]
        public void RemoveNthFromEndTest04()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            int index = 4;

            ListNode result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, index);


        }
    }
}