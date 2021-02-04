using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class SlidingWindowMedian
    {
        /// <summary>
        /// 给你一个数组 nums，有一个长度为 k 的窗口从最左端滑动到最右端。窗口中有 k 个数，每次窗口向右移动 1 位。你的任务是找出每次窗口移动后得到的新窗口中元素的中位数，并输出由它们组成的数组
        /// 给出 nums = [1,3,-1,-3,5,3,6,7]，以及 k = 3。
        ///      窗口位置               中位数
        ///---------------               -----
        /// [1  3  -1] -3  5  3  6  7      1
        /// 1 [3  -1  -3] 5  3  6  7      -1
        /// 1  3 [-1  -3  5] 3  6  7      -1
        /// 1  3  -1 [-3  5  3] 6  7       3
        /// 1  3  -1  -3 [5  3  6] 7       5
        /// 1  3  -1  -3  5 [3  6  7]      6
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            IList<double> result = new List<double>();
            double median;
            if (k > nums.Length)
            {
                return result.ToArray(); ;
            }

            Queue<double> queue = new Queue<double>();

            foreach (var item in nums)
            {
                queue.Enqueue(item);

                if(queue.Count == k)
                {
                    median = this.GetMedianInQueue(queue);
                    result.Add(median);
                    queue.Dequeue();

                }
            }


            return result.ToArray();
        }

        private double GetMedianInQueue(Queue<double> queue)
        {
            List<double> window = new List<double>();

            foreach (var item in queue)
            {
                window.Add(item);
            }
            window.Sort();
            
            double medianIndex = (queue.Count - 1) / 2.0;
            double result = (window[(int)Math.Floor(medianIndex)] + window[(int)Math.Ceiling(medianIndex)]) / 2.0;
            
            return result;
        }

    }
}
