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
    public class MergeTwoSortedListsTests
    {
        [Test()]
        public void MergeTwoListsTest()
        {
            //0,1,3,5
            //2,4,6
            //expected = 0,1,2,3,4,5,6
            ListNode head1 = new ListNode(0);
            ListNode body01 = new ListNode(1);
            ListNode body02 = new ListNode(3);
            ListNode body03 = new ListNode(5);
            ListNode head2 = new ListNode(2);
            ListNode body05 = new ListNode(4);
            ListNode body06 = new ListNode(6);
            head1.next = body01;
            body01.next = body02;
            body02.next = body03;
            
            head2.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }
        [Test()]
        public void MergeTwoListsTest02()
        {
            //1,3,5
            //2,4,6,8
            //expected:1,2,3,4,5,6,8
            ListNode head1 = new ListNode(1);
            ListNode body01 = new ListNode(3);
            ListNode body02 = new ListNode(5);
            ListNode head2 = new ListNode(2);
            ListNode body04 = new ListNode(4);
            ListNode body05 = new ListNode(6);
            ListNode body06 = new ListNode(8);
            head1.next = body01;
            body01.next = body02;
            head2.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }


        [Test()]
        public void MergeTwoListsTest03()
        {
            //1
            //2,3,4,5,6,8
            //expected:1,2,3,4,5,6,8
            ListNode head1 = new ListNode(1);
            ListNode body01 = new ListNode(3);
            ListNode body02 = new ListNode(5);
            ListNode head2 = new ListNode(2);
            ListNode body04 = new ListNode(4);
            ListNode body05 = new ListNode(6);
            ListNode body06 = new ListNode(8);
            body01.next = body04;
            head2.next = body01;
            body04.next = body02;
            body02.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }

        [Test()]
        public void MergeTwoListsTest04()
        {
            //1,2,3,5,6,6
            //4
            //expected:1,2,3,4,5,6,6
            ListNode head1 = new ListNode(1);
            ListNode body01 = new ListNode(2);
            ListNode body02 = new ListNode(3);
            ListNode head2 = new ListNode(4);
            ListNode body04 = new ListNode(5);
            ListNode body05 = new ListNode(6);
            ListNode body06 = new ListNode(6);
            head1.next = body01;
            body01.next = body02;
            body02.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }
        [Test()]
        public void MergeTwoListsTest05()
        {
            //1,2,3,5,6,6
            //null
            //expected:1,2,3,5,6,6
            ListNode head1 = new ListNode(1);
            ListNode body01 = new ListNode(2);
            ListNode body02 = new ListNode(3);
            ListNode head2 = null;
            ListNode body04 = new ListNode(5);
            ListNode body05 = new ListNode(6);
            ListNode body06 = new ListNode(6);
            head1.next = body01;
            body01.next = body02;
            body02.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }
        [Test()]
        public void MergeTwoListsTest06()
        {
            //null
            //4
            //expected:4
            ListNode head1 =null;
            ListNode head2 = new ListNode(4);

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head2, result);
        }
        [Test()]
        public void MergeTwoListsTest07()
        {
            //null
            //null
            //expected:null
            ListNode head1 = null;
            ListNode head2 = null;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }
        [Test()]
        public void MergeTwoListsTest08()
        {
            //1,2,3
            //4,5,6,7
            //expected:1,2,3,4,5,6,7
            ListNode head1 = new ListNode(1);
            ListNode body01 = new ListNode(2);
            ListNode body02 = new ListNode(3);
            ListNode head2 = new ListNode(4);
            ListNode body04 = new ListNode(5);
            ListNode body05 = new ListNode(6);
            ListNode body06 = new ListNode(7);
            head1.next = body01;
            body01.next = body02;
            head2.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }


        [Test()]
        public void MergeTwoListsTest09()
        {
            //1,4,5
            //2,3,6,7
            //expected:1,2,3,4,5,6,7
            ListNode head1 = new ListNode(1);
            ListNode body01 = new ListNode(4);
            ListNode body02 = new ListNode(5);
            ListNode head2 = new ListNode(2);
            ListNode body04 = new ListNode(3);
            ListNode body05 = new ListNode(6);
            ListNode body06 = new ListNode(7);
            head1.next = body01;
            body01.next = body02;
            head2.next = body04;
            body04.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head1, result);
        }
        [Test()]
        public void MergeTwoListsTest10()
        {
            //2,3,6,7
            //1,4,5
            //expected:1,2,3,4,5,6,7
            ListNode head1 = new ListNode(2);
            ListNode body01 = new ListNode(3);
            ListNode body02 = new ListNode(6);
            ListNode body04 = new ListNode(7);
            ListNode head2 = new ListNode(1);
            ListNode body05 = new ListNode(4);
            ListNode body06 = new ListNode(5);
            head1.next = body01;
            body01.next = body02;
            body02.next = body04;
            head2.next = body05;
            body05.next = body06;

            ListNode result = new MergeTwoSortedLists().MergeTwoLists(head1, head2);

            Assert.AreEqual(head2, result);
        }
    }
}