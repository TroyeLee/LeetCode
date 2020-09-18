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
    public class RotateListTests
    {
        [Test()]
        public void RotateRightTest()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[]{ 1,2,3,4,5 });
            int[] expected = { 4,5,1,2,3};

            ListNode result = new RotateList().RotateRight(head, 2);

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }
        }
        [Test()]
        public void RotateRightTest02()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[] {0 ,1 ,2 });
            int[] expected = { 2,0,1 };

            ListNode result = new RotateList().RotateRight(head, 4);

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }
        }

        [Test()]
        public void RotateRightTest03()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[] { 0, 1, 2 , 3 , 4, 5});
            int[] expected = { 0,1,2,3,4,5};

            ListNode result = new RotateList().RotateRight(head, 6);

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }
        }

        [Test()]
        public void RotateRightTest04()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[] { 1, 2, 3, 4, 5 });
            int[] expected = { 4, 5, 1, 2, 3 };

            ListNode result = new RotateList().RotateRight02(head, 2);

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }
        }
        [Test()]
        public void RotateRightTest05()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[] { 0, 1, 2 });
            int[] expected = { 2, 0, 1 };

            ListNode result = new RotateList().RotateRight02(head, 4);

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }
        }

        [Test()]
        public void RotateRightTest06()
        {
            ListNode head = new CommonUtil().BuildListNode(new int[] { 0, 1, 2, 3, 4, 5 });
            int[] expected = { 0, 1, 2, 3, 4, 5 };

            ListNode result = new RotateList().RotateRight02(head, 6);

            foreach (var item in expected)
            {
                Assert.AreEqual(item, result.val);
                result = result.next;
            }
        }
    }
}