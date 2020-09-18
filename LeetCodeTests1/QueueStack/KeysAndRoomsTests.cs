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
    public class KeysAndRoomsTests
    {
        [Test()]
        public void CanVisitAllRoomsTest()
        {
            IList<IList<int>> rooms = new List<IList<int>>() {
            new List<int>(){1 },

            new List<int>(){ 2},

            new List<int>(){ 3},

            new List<int>(){ }
            };

            bool expected = true;

            bool result = new KeysAndRooms().CanVisitAllRooms(rooms);

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void CanVisitAllRoomsTest02()
        {
            IList<IList<int>> rooms = new List<IList<int>>() {
            new List<int>(){1,3 },

            new List<int>(){ 3,0,1},

            new List<int>(){ 2},

            new List<int>(){ 0}
            };

            bool expected = false;

            bool result = new KeysAndRooms().CanVisitAllRooms(rooms);

            Assert.AreEqual(expected, result);
        }


        [Test()]
        public void CanVisitAllRoomsTest03()
        {
            IList<IList<int>> rooms = new List<IList<int>>();

            bool expected = false;

            bool result = new KeysAndRooms().CanVisitAllRooms(rooms);

            Assert.AreEqual(expected, result);
        }
    }
}