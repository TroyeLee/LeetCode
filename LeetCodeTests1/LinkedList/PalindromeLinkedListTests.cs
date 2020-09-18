using NUnit.Framework;
using LeetCode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using System.Runtime.CompilerServices;

namespace LeetCode.LinkedList.Tests
{
    [TestFixture()]
    public class PalindromeLinkedListTests
    {
        [Test()]
        public void IsPalindromeTest()
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

            bool result = new PalindromeLinkedList().IsPalindrome(head);

            bool expected = false;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void IsPalindromeTest02()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            ListNode body04 = new ListNode(2);
            ListNode body05 = new ListNode(1);
            ListNode body06 = new ListNode(0);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body04;
            body04.next = body05;
            body05.next = body06;

            bool result = new PalindromeLinkedList().IsPalindrome(head);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }


        [Test()]
        public void IsPalindromeTest03()
        {
            ListNode head = null;

            bool result = new PalindromeLinkedList().IsPalindrome(head);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void IsPalindromeTest04()
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

            bool result = new PalindromeLinkedList().IsPalindrome02(head);

            bool expected = false;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void IsPalindromeTest05()
        {
            ListNode head = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(2);
            ListNode body03 = new ListNode(3);
            ListNode body04 = new ListNode(2);
            ListNode body05 = new ListNode(1);
            ListNode body06 = new ListNode(0);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;
            body03.next = body04;
            body04.next = body05;
            body05.next = body06;

            bool result = new PalindromeLinkedList().IsPalindrome02(head);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }


        [Test()]
        public void IsPalindromeTest06()
        {
            ListNode head = null;

            bool result = new PalindromeLinkedList().IsPalindrome02(head);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}