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
    public class IntersectionOfTwoLinkedListsTests
    {
        [Test()]
        public void GetIntersectionNodeTest()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            bodyA2.next = body3;
            ListNode headB = new ListNode(4);
            headB.next = body3;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
            ListNode expected = body3;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest02()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = new ListNode(4);
            headB.next = body3;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest03()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = null;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest04()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = headA;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
            ListNode expected = headA;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest05()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = new ListNode(4);
            headB.next = headA;
            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
            ListNode expected = headA;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest06()
        {
            ListNode headA = new ListNode(2);
            ListNode bodyA1 = new ListNode(2);
            ListNode headB = new ListNode(2);
            ListNode bodyB1 = new ListNode(2);
            ListNode body1 = new ListNode(4);
            ListNode body2 = new ListNode(5);
            ListNode body3 = new ListNode(4);
            headA.next = bodyA1;
            bodyA1.next = body1;
            body1.next = body2;
            body2.next = body3;
            headB.next = bodyB1;
            bodyB1.next = body1;
            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
            ListNode expected = body1;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest07()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            bodyA2.next = body3;
            ListNode headB = new ListNode(4);
            headB.next = body3;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode02(headA, headB);
            ListNode expected = body3;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest08()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = new ListNode(4);
            headB.next = body3;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode02(headA, headB);
            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest09()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = null;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode02(headA, headB);
            ListNode expected = null;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest10()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = headA;

            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode02(headA, headB);
            ListNode expected = headA;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest11()
        {
            ListNode headA = new ListNode(0);
            ListNode bodyA1 = new ListNode(1);
            ListNode bodyA2 = new ListNode(2);
            ListNode body3 = new ListNode(3);
            headA.next = bodyA1;
            bodyA1.next = bodyA2;
            ListNode headB = new ListNode(4);
            headB.next = headA;
            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode02(headA, headB);
            ListNode expected = headA;

            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void GetIntersectionNodeTest12()
        {
            ListNode headA = new ListNode(2);
            ListNode bodyA1 = new ListNode(2);
            ListNode headB = new ListNode(2);
            ListNode bodyB1 = new ListNode(2);
            ListNode body1 = new ListNode(4);
            ListNode body2 = new ListNode(5);
            ListNode body3 = new ListNode(4);
            headA.next = bodyA1;
            bodyA1.next = body1;
            body1.next = body2;
            body2.next = body3;
            headB.next = bodyB1;
            bodyB1.next = body1;
            ListNode result = new IntersectionOfTwoLinkedLists().GetIntersectionNode02(headA, headB);
            ListNode expected = body1;

            Assert.AreEqual(expected, result);
        }
    }
}