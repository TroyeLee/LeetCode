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
    public class OpenTheLockTests
    {
        [Test()]
        public void OpenLockTest()
        {
            string[] deads = new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" };
            string target = "8888";
            int result02 = new OpenTheLock().OpenLock(deads, target);

            int expect = -1;

            Assert.AreEqual(expect, result02);
        }
    }
}