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
    public class MyLinkedListTests
    {
        [Test()]
        public void MyLinkedListTest()
        {
            MyLinkedList obj = new MyLinkedList();
            obj.AddAtHead(7);
            obj.AddAtHead(2);
            obj.AddAtHead(1);
            obj.AddAtIndex(3, 0);
            obj.DeleteAtIndex(2);
            obj.AddAtHead(6);
            obj.AddAtTail(4);
            int result = obj.Get(4);
            obj.AddAtHead(4);
            obj.AddAtIndex(5,0);
            obj.AddAtHead(6);
            Assert.AreEqual(4, result);
        }

        [Test()]
        public void GetTest()
        {

        }

        [Test()]
        public void AddAtHeadTest()
        {

        }

        [Test()]
        public void AddAtTailTest()
        {

        }

        [Test()]
        public void AddAtIndexTest()
        {

        }

        [Test()]
        public void DeleteAtIndexTest()
        {

        }
    }
}