using NUnit.Framework;
using LeetCode.QueueStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack.Tests
{
    [TestFixture()]
    public class MyCircularQueueTests
    {
        [Test()]
        public void MyCircularQueueTest()
        {

            MyCircularQueue myCircularQueue = new MyCircularQueue(10);
        }

        [Test()]
        public void EnQueueTest()
        {
            MyCircularQueue myCircularQueue = new MyCircularQueue(3);
            myCircularQueue.EnQueue(1);
        }

        [Test()]
        public void DeQueueTest()
        {
            MyCircularQueue myCircularQueue = new MyCircularQueue(3);
            myCircularQueue.EnQueue(1);
            myCircularQueue.EnQueue(2);
            myCircularQueue.EnQueue(3);
            myCircularQueue.EnQueue(4);

        }

        [Test()]
        public void FrontTest()
        {
        }

        [Test()]
        public void RearTest()
        {
        }

        [Test()]
        public void IsEmptyTest()
        {
        }

        [Test()]
        public void IsFullTest()
        {
        }
    }
}