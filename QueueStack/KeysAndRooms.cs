using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class KeysAndRooms
    {
        /// <summary>
        /// 钥匙和房间
        ///   有 N 个房间，开始时你位于 0 号房间。每个房间有不同的号码：0，1，2，...，N-1，并且房间里可能有一些钥匙能使你进入下一个房间。
        ///   在形式上，对于每个房间 i 都有一个钥匙列表 rooms[i]，每个钥匙 rooms[i][j] 由[0, 1，...，N - 1] 中的一个整数表示，其中 N = rooms.length。 钥匙 rooms[i][j] = v 可以打开编号为 v 的房间。
        ///   最初，除 0 号房间外的其余所有房间都被锁住。
        ///   你可以自由地在房间之间来回走动。
        ///   如果能进入每个房间返回 true，否则返回 false。
        ///     输入：[[1,3],[3,0,1],[2],[0]]
        ///     输出：false
        ///     解释：我们不能进入 2 号房间。
        /// </summary>
        /// <param name="rooms"></param>
        /// <returns></returns>
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            if (rooms.Count == 0)
            {
                return false;
            }
            HashSet<int> visited = new HashSet<int>();

            Queue<int> queue = new Queue<int>();

            GetKeys(rooms, queue, 0, visited);
            visited.Add(0);
            while (queue.Count > 0)
            {
                int room = queue.Dequeue();
                GetKeys(rooms,queue,room,visited);
            }

            return visited.Count == rooms.Count;
        }

        private void GetKeys(IList<IList<int>> rooms , Queue<int> queue , int room , HashSet<int> visited)
        {
            for (int i = 0; i < rooms[room].Count; i++)
            {
                if (!visited.Contains(rooms[room][i]))
                {
                    queue.Enqueue(rooms[room][i]);
                    visited.Add(rooms[room][i]);
                }
            }
        }
    }
}
