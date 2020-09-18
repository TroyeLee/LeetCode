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
    public class BinaryTreeInorderTraversalTests
    {
        [Test()]
        public void InorderTraversalTest()
        {
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            n2.left = n3;
            n1.right = n2;

            IList<int> result = new BinaryTreeInorderTraversal().InorderTraversal2(n1);

            IList<int> expected = new List<int>() { 1, 3, 2 };

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }
    }
}