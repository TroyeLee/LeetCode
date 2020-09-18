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
    public class IntersectionOfTwoArraysTests
    {
        [Test()]
        public void IntersectionTest()
        {
            int[] nums1 = {1,2,3,4,5,6,7,3,4,5,6 };
            int[] nums2 = {1,3,5,7,6,6,8 };
            int[] result = new IntersectionOfTwoArrays().Intersection(nums1, nums2);
            int[] expected = {1,3,5,7,6 };

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}