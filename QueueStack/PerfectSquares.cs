using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class PerfectSquares
    {
        /// <summary>
        /// 完全平方数
        /// 给定正整数 n，找到若干个完全平方数（比如 1, 4, 9, 16, ...）使得它们的和等于 n。你需要让组成和的完全平方数的个数最少。
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares(int n)
        {
            //利用树的思想，每个节点是父节点的（父节点 - i的平方），然后用广度优先搜索，直到搜索到结果为0
            int result = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            HashSet<int> marked = new HashSet<int>();

            while (queue.Count > 0)
            {
                result++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int cur = queue.Dequeue();
                    for (int j = 1; cur - j * j >= 0; j++)
                    {
                        int temp = cur - j * j;
                        if (temp == 0)
                        {
                            return result;
                        }
                        if (!marked.Contains(temp))
                        {
                            marked.Add(temp);
                        }
                        queue.Enqueue(temp);
                    }
                }
            }


            return -1;
        }
    }
}
