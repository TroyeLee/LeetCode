using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class HappyNumber
    {
        /// <summary>
        /// 快乐数
        /// 编写一个算法来判断一个数 n 是不是快乐数。
        /// 
        ///     「快乐数」定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，然后重复这个过程直到这个数变为 1，
        ///     也可能是 无限循环 但始终变不到 1。如果 可以变为  1，那么这个数就是快乐数。
        ///     如果 n 是快乐数就返回 True ；不是，则返回 False 。
        ///       输入：19
        ///       输出：true
        ///       解释：
        ///       1^2 + 9^2 = 82
        ///       8^2 + 2^2 = 68
        ///       6^2 + 8^2 = 100
        ///       1^2 + 0^2 + 02 = 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsHappy(int n)
        {
            //1,结果为1
            //2,结果产生循环，永远不为1
            //3,结果越来越大直到无穷大（不会发生，9-->81,99-->162,999-->243,9999-->324,9999999999999-->1053,当数值达到最大时，会跌落到四位数，产生循环）


            HashSet<int> temp = new HashSet<int>();
            int calculate = n;
            while (!temp.Contains(calculate))
            {
                if (calculate == 1)
                {
                    return true;
                }
                temp.Add(calculate);
                calculate = Calculate(calculate);
            }

            return false;
        }

        private int Calculate(int n)
        {
            int result = 0;
            string ns = n.ToString();
            foreach (var item in ns)
            {
                result += (int)Math.Pow(item - '0', 2);
            }

            return result;
        }
    }
}
