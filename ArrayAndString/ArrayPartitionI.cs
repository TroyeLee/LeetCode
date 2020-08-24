using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class ArrayPartitionI
    {
        /// <summary>
        /// 数组拆分1
        /// 给定长度为 2n 的数组, 你的任务是将这些数分成 n 对, 例如 (a1, b1), (a2, b2), ..., (an, bn) ，使得从1 到 n 的 min(ai, bi) 总和最大。
        ///   输入: [1,4,3,2]
        ///   输出: 4
        ///   解释: n 等于 2, 最大总和为 4 = min(1, 2) + min(3, 4).
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ArrayPairSum(int[] nums)
        {
            int result = 0;
            //升序，取奇数/相邻最小值
            quickSort(nums, 0, nums.Length - 1);
            for (int i = 0; i < nums.Length; i += 2)
            {
                result += Math.Min(nums[i], nums[i + 1]);
            }


            return result;
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="data"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private void quickSort(int[] data, int low, int high)
        {
            if (low < high)
            {
                int loc = Partition(data, low, high);//获取以low为依据，区分界限
                quickSort(data, low, loc - 1);
                quickSort(data, loc + 1, high);
            }
        }

        private int Partition(int[] data, int low, int high)
        {
            int i, j;
            int pivot;
            pivot = data[low];
            i = low;
            j = high;
            while (i < j)
            {
                while (i < j && data[j] >= pivot) j--; //大于的不管，小于的跳出，与i交换
                data[i] = data[j];
                while (i < j && data[i] <= pivot) i++;//小于的不管，大于的跳出，与j交换，直至i==j，那i/j就是界限
                data[j] = data[i];
            }
            data[i] = pivot;//讲参考值赋值到界限
            return i;//返回界限
        }
    }
}
