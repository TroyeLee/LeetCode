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
    public class MinimumIndexSumOfTwoListsTests
    {
        [Test()]
        public void FindRestaurantTest()
        {
            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
            string[] result = new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            string[] expected = { "Shogun" };
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected[0], result[0]);
        }

        [Test()]
        public void FindRestaurantTest02()
        {
            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "KFC", "Shogun", "Burger King" };
            string[] result = new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            string[] expected = { "Shogun" };
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected[0], result[0]);
        }

        [Test()]
        public void FindRestaurantTest03()
        {
            string[] list1 = { "a", "b", "c", "d" ,"e","f","g"};
            string[] list2 = { "g", "f", "e" ,"a","c"};
            string[] result = new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            string[] expected = { "a" };
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected[0], result[0]);
        }

        [Test()]
        public void FindRestaurantTest04()
        {
            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "KFC", "Burger King", "Tapioca Express", "Shogun" };
            string[] result = new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            string[] expected = { "KFC","Burger King","Tapioca Express","Shogun"};

            Assert.AreEqual(expected.Length, result.Length);
        }

        [Test()]
        public void FindRestaurantTest05()
        {
            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "KNN", "KFC", "Burger King", "Tapioca Express", "Shogun" };
            string[] result = new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            string[] expected = { "KFC","Burger King","Tapioca Express","Shogun" };

            Assert.AreEqual(expected.Length, result.Length);
        }

        [Test()]
        public void FindRestaurantTest06()
        {
            string[] list1 = { "vacag", "KFC" };
            string[] list2 = { "fvo", "xrljq", "jrl", "KFC" };
            string[] result = new MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            string[] expected = { "KFC", "Burger King", "Tapioca Express", "Shogun" };

            Assert.AreEqual(expected.Length, result.Length);
        }
    }
}