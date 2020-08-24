using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayAndString
{
    public class TwoSumIIInputArrayIsSorted
    {
        /// <summary>
        /// 两数之和 II - 输入有序数组
        /// 给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。
        /// 函数应该返回这两个下标值 index1 和 index2，其中 index1 必须小于 index2。
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2] { 1, 2 };
            if (numbers.Length <= 2)
            {
                return result;
            }
            int head, tail;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                head = i;
                tail = numbers.Length - 1;
                while (head <= tail)
                {
                    int center = (head == tail - 1) ? tail : (head + tail) / 2;
                    int temp = numbers[i] + numbers[center];
                    if (temp > target)
                    {
                        tail = center - 1;
                    }
                    else if (temp < target)
                    {
                        head = center + 1;
                    }
                    else
                    {
                        result[0] = i + 1;
                        result[1] = center + 1;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
