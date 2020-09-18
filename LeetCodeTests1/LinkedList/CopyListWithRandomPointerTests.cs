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
    public class CopyListWithRandomPointerTests
    {
        [Test()]
        public void CopyRandomListTest()
        {
            //[0,2],[1,0],[2,0],[3,1]
            NodeRandom head = new NodeRandom(0);
            NodeRandom body01 = new NodeRandom(1);
            NodeRandom body02 = new NodeRandom(2);
            NodeRandom body03 = new NodeRandom(3);
            head.next = body01;
            body01.next = body02;
            body02.next = body03;

            head.random = body02;
            body01.random = head;
            body02.random = head;
            body03.random = body01;

            NodeRandom result = new CopyListWithRandomPointer().CopyRandomList(head);

            NodeRandom expected = head;

            while (result != null)
            {
                Assert.AreEqual(expected.val,result.val);
                if (result.random != null)
                {
                    Assert.AreEqual(expected.random.val, result.random.val);
                }
                result = result.next;
                expected = expected.next;
            }

            
        }
    }
}