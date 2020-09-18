using NUnit.Framework;
using LeetCode.ArrayAndString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString.Tests
{
    [TestFixture()]
    public class MoveZeroesCSTests
    {
        [Test()]
        public void MoveZeroesTest()
        {
            int[] test = { 0, 1, 0, 3, 12 };
            int[] expected = { 1, 3, 12, 0, 0 };
            new MoveZeroesCS().MoveZeroes(test);
            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(expected[i], test[i]);
            }
    }
    }
}