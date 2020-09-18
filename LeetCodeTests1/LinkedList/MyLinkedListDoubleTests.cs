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
    public class MyLinkedListDoubleTests
    {
        [Test()]
        public void MyLinkedListDoubleTest()
        {
            MyLinkedListDouble myLinkedList = new MyLinkedListDouble();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);
            int result = myLinkedList.Get(1);
            Assert.AreEqual(2,result);
            myLinkedList.DeleteAtIndex(1);
            result = myLinkedList.Get(1);
            Assert.AreEqual(3, result);
        }
        [Test()]
        public void MyLinkedListDoubleTest02()
        {
            MyLinkedListDouble myLinkedList = new MyLinkedListDouble();
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(0);
            int result = myLinkedList.Get(0);
            Assert.AreEqual(-1, result);
        }

        [Test()]
        public void MyLinkedListDoubleTest03()
        {
            MyLinkedListDouble myLinkedList = new MyLinkedListDouble();
            myLinkedList.AddAtHead(4);
            int result = myLinkedList.Get(1);
            Assert.AreEqual(-1, result);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtHead(5);
            myLinkedList.DeleteAtIndex(3);
            myLinkedList.AddAtHead(7);
            result =myLinkedList.Get(3);
            Assert.AreEqual(4, result);
            result =myLinkedList.Get(3);
            Assert.AreEqual(4, result);
            result = myLinkedList.Get(3);
            Assert.AreEqual(4, result);
            myLinkedList.AddAtTail(1);
            result = myLinkedList.Get(4);
            Assert.AreEqual(1, result);
            myLinkedList.DeleteAtIndex(4);
        }

        [Test()]
        public void MyLinkedListDoubleTest04()
        {
            MyLinkedListDouble myLinkedList = new MyLinkedListDouble();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtIndex(3,0);
            myLinkedList.DeleteAtIndex(2);
            myLinkedList.AddAtHead(6);
            myLinkedList.AddAtTail(4);

            int result = myLinkedList.Get(4);
            Assert.AreEqual(4, result);
            myLinkedList.AddAtHead(4);

            myLinkedList.AddAtIndex(5, 0);
            myLinkedList.AddAtHead(6);
        }
    }
}