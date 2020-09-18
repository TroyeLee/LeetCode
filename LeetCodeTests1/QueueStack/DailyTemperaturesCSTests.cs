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
    public class DailyTemperaturesCSTests
    {
        [Test()]
        public void DailyTemperaturesTest()
        {
            int[] test04 = new int[] { 55, 38, 53, 81, 61, 93, 97, 32, 43, 78 };
            int[] result = new DailyTemperaturesCS().DailyTemperatures(test04);
            int[] expected = new int[] {3,1,1,2,1,1,0,1,1,0 };
            //Assert.AreEqual(expected, result);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}