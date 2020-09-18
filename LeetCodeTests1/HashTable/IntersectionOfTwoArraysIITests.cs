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
    public class IntersectionOfTwoArraysIITests
    {
        [Test()]
        public void IntersectTest()
        {
            int[] nums1 = {1,2,3,5,6,7 };
            int[] nums2 = { 2,3,3,4,7};
            int[] expected = { 2, 3 ,7};
            int[] result = new IntersectionOfTwoArraysII().Intersect(nums1, nums2);
        }

        [Test()]
        public void IntersectTest02()
        {
            int[] nums1 = { 1, 2, 2,2, 1 };
            int[] nums2 = { 2, 2 };
            int[] expected = { 2, 2 };
            int[] result = new IntersectionOfTwoArraysII().Intersect(nums1, nums2);
        }

        [Test()]
        public void IntersectTest03()
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 3,4 };
            int[] expected = { };
            int[] result = new IntersectionOfTwoArraysII().Intersect(nums1, nums2);
        }
    }
}