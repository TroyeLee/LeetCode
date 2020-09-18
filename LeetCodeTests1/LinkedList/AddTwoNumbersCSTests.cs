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
    public class AddTwoNumbersCSTests
    {
        [Test()]
        public void AddTwoNumbersTest()
        {
            //1,2,3
            //4,5,6
            //expected:5,7,9
            ListNode head1 = new CommonUtil().BuildListNode(new int[] {1,2,3 });
            ListNode head2 = new CommonUtil().BuildListNode(new int[] { 4,5,6 });

            ListNode result = new AddTwoNumbersCS().AddTwoNumbers(head1, head2);
            int[] expected = { 5, 7, 9 };
            foreach (var expect in expected)
            {
                Assert.AreEqual(expect, result.val);
                result = result.next;
            }
        }

        [Test()]
        public void AddTwoNumbersTest02()
        {
            //6,2,4
            //4,5,6
            //expected:0,8,0,1
            ListNode head1 = new ListNode(6);
            ListNode body01 = new ListNode(2);
            ListNode body02 = new ListNode(4);
            ListNode head2 = new ListNode(4);
            ListNode body04 = new ListNode(5);
            ListNode body05 = new ListNode(6);
            head1.next = body01;
            body01.next = body02;
            head2.next = body04;
            body04.next = body05;

            ListNode result = new AddTwoNumbersCS().AddTwoNumbers(head1, head2);
            int[] expected = { 0,8,0,1 };
            foreach (var expect in expected)
            {
                Assert.AreEqual(expect, result.val);
                result = result.next;
            }
        }
        [Test()]
        public void AddTwoNumbersTest03()
        {
            //1,2,4,5
            //4,5,6
            //expected:5,7,0,6
            ListNode head1 = new CommonUtil().BuildListNode(new int[] { 1, 2, 4, 5 });
            ListNode head2 = new CommonUtil().BuildListNode(new int[] { 4,5,6});

            ListNode result = new AddTwoNumbersCS().AddTwoNumbers(head1, head2);
            int[] expected = { 5, 7, 0,6 };
            foreach (var expect in expected)
            {
                Assert.AreEqual(expect, result.val);
                result = result.next;
            }
        }

        [Test()]
        public void AddTwoNumbersTest04()
        {
            //null
            //4,5,6
            //expected:4,5,6
            ListNode head1 = null;
            ListNode head2 = new CommonUtil().BuildListNode(new int[]{ 4,5,6 });

            ListNode result = new AddTwoNumbersCS().AddTwoNumbers(head1, head2);
            int[] expected = { 4,5,6 };
            foreach (var expect in expected)
            {
                Assert.AreEqual(expect, result.val);
                result = result.next;
            }
        }
        [Test()]
        public void AddTwoNumbersTest05()
        {
            //0
            //4,5,6
            //expected:4,5,6
            int[] data1 = { 0 };
            int[] data2 = { 4, 5, 6 };
            ListNode head1 = new CommonUtil().BuildListNode(data1);
            ListNode head2 = new CommonUtil().BuildListNode(data2);

            ListNode result = new AddTwoNumbersCS().AddTwoNumbers(head1, head2);
            int[] expected = { 4, 5, 6 };
            foreach (var expect in expected)
            {
                Assert.AreEqual(expect, result.val);
                result = result.next;
            }
        }

        [Test()]
        public void AddTwoNumbersTest06()
        {
            //0
            //0
            //expected:0
            int[] data1 = { 0 };
            int[] data2 = { 0 };
            ListNode head1 = new CommonUtil().BuildListNode(data1);
            ListNode head2 = new CommonUtil().BuildListNode(data2);

            ListNode result = new AddTwoNumbersCS().AddTwoNumbers(head1, head2);
            int[] expected = { 0};
            foreach (var expect in expected)
            {
                Assert.AreEqual(expect, result.val);
                result = result.next;
            }
        }
    }
}