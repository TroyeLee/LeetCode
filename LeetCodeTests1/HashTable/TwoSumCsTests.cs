using NUnit.Framework;
using LeetCode.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable.Tests
{
    [TestFixture()]
    public class TwoSumCsTests
    {
        [Test()]
        public void TwoSumTest()
        {
            int[] test = {1,2,3,4,5,6 };
            int target = 7;
            int[] expected = { 2, 3 };

            int[] result = new TwoSumCs().TwoSum(test, target);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [Test()]
        public void TwoSumTest02()
        {
            int[] test = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = {0,1};

            int[] result = new TwoSumCs().TwoSum(test, target);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }


        [Test()]
        public void TwoSumTest03()
        {
            int[] test = { 1, 2, 2, 4, 5, 6 };
            int target = 6;
            int[] expected = { 1, 3 };

            int[] result = new TwoSumCs().TwoSum(test, target);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [Test()]
        public void TwoSumTest04()
        {
            int[] test = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };

            int[] result = new TwoSumCs().TwoSum(test, target);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}