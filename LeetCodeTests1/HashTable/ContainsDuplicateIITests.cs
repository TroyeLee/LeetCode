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
    public class ContainsDuplicateIITests
    {
        [Test()]
        public void ContainsNearbyDuplicateTest()
        {
            int[] nums ={ 1, 2, 3, 1 };
            int k = 3;
            bool expected = true;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void ContainsNearbyDuplicateTest01()
        {
            int[] nums = { 1, 0, 1, 1 };
            int k = 1;
            bool expected = true;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsNearbyDuplicateTest02()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool expected = false;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsNearbyDuplicateTest03()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 4;
            bool expected = true;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void ContainsNearbyDuplicateTest04()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;
            bool expected = true;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate02(nums, k);
            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void ContainsNearbyDuplicateTest05()
        {
            int[] nums = { 1, 0, 1, 1 };
            int k = 1;
            bool expected = true;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate02(nums, k);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsNearbyDuplicateTest06()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool expected = false;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate02(nums, k);
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void ContainsNearbyDuplicateTest07()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 4;
            bool expected = true;
            bool result = new ContainsDuplicateII().ContainsNearbyDuplicate02(nums, k);
            Assert.AreEqual(expected, result);
        }
    }
}