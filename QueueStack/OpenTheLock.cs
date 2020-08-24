using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class OpenTheLock
    {
        /// <summary>
        /// 打开转盘锁
        /// 你有一个带有四个圆形拨轮的转盘锁。每个拨轮都有10个数字： '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' 。
        /// 每个拨轮可以自由旋转：例如把 '9' 变为  '0'，'0' 变为 '9' 。每次旋转都只能旋转一个拨轮的一位数字。
        /// 锁的初始数字为 '0000' ，一个代表四个拨轮的数字的字符串。
        /// 列表 deadends 包含了一组死亡数字，一旦拨轮的数字和列表里的任何一个元素相同，这个锁将会被永久锁定，无法再被旋转。
        /// 字符串 target 代表可以解锁的数字，你需要给出最小的旋转次数，如果无论如何不能解锁，返回 -1。
        /// </summary>
        /// <param name="deadends"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int OpenLock(string[] deadends, string target)
        {
            /*将每个相邻的答案看成一张图，每个节点有八个相邻的答案 ，
             * 0000 （1000，9000，0100，0900，0010，0090，0001，0009），
             * 每个轮盘皆可向上/下滑动一步，得到相邻的节点，
             * 以此为中心思想进行广度优先查询*/

            int result = 0;
            //死亡列表
            HashSet<string> deads = new HashSet<string>(deadends);
            //已访问
            HashSet<string> marked = new HashSet<string>();
            //存储队列
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("0000");

            marked.Add("0000");


            while (queue.Count != 0)
            {
                //以获取当前队列长度，获取每个节点的相邻节点（死亡节点除外），将其添加到队列。
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    //获取队列第一个节点，并出队，判断结果
                    string cur = queue.Dequeue();
                    if (deads.Contains(cur))
                    {
                        continue;
                    }
                    if (cur.Equals(target))
                    {
                        return result;
                    }
                    for (int j = 0; j < 4; j++)
                    {

                        string ups = DoUp(j, cur);//向上滑一步
                        if (!deads.Contains(ups) && !marked.Contains(ups))
                        {
                            marked.Add(ups);
                            queue.Enqueue(ups);
                        }

                        string downs = DoDown(j, cur);//向下滑一步
                        if (!deads.Contains(downs) && !marked.Contains(downs))
                        {
                            marked.Add(downs);
                            queue.Enqueue(downs);
                        }

                    }

                }
                result++;
            }

            return -1;
        }

        private string DoUp(int i, string s)
        {
            char[] ch = s.ToCharArray();
            if (ch[i] == '9')
            {
                ch[i] = '0';
            }
            else
                ch[i]++;

            return new string(ch);
        }

        private string DoDown(int i, string s)
        {
            char[] ch = s.ToCharArray();
            if (ch[i] == '0')
            {
                ch[i] = '9';
            }
            else
                ch[i]--;
            return new string(ch);
        }
    }
}
