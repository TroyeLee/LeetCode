using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    public class MinimumIndexSumOfTwoLists
    {
        /// <summary>
        /// 两个列表的最小索引总和
        /// 假设Andy和Doris想在晚餐时选择一家餐厅，并且他们都有一个表示最喜爱餐厅的列表，每个餐厅的名字用字符串表示。
        /// 你需要帮助他们用最少的索引和找出他们共同喜爱的餐厅。 如果答案不止一个，则输出所有答案并且不考虑顺序。 你可以假设总是存在一个答案。
        ///    输入:
        ///    ["Shogun", "Tapioca Express", "Burger King", "KFC"]
        ///    ["KFC", "Shogun", "Burger King"]
        ///    输出: ["Shogun"]
        ///    解释: 他们共同喜爱且具有最小索引和的餐厅是“Shogun”，它有最小的索引和1(0+1)。
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            int length1 = list1.Length;
            int length2 = list2.Length;
            if(length1 == 0 || length2== 0)
            {
                return null;
            }
            int length = length1 > length2 ? length1 : length2;
            string[] result = new string[1];
            int minSumIndex = length1 + length2 + length ;
            IDictionary<string, int> map = new Dictionary<string, int>();
            IDictionary<string, int> bothLike = new Dictionary<string, int>();
            for (int i = 0; i < length; i++)
            {
                minSumIndex = GetIndexSum(list1, i, length1, map, result, minSumIndex , length, bothLike);
                minSumIndex = GetIndexSum(list2, i, length2, map, result, minSumIndex , length, bothLike);
            }

            return bothLike.Where(u => u.Value == minSumIndex).Select(u=>u.Key).ToArray();
        }

        private int GetIndexSum(string[] list , int i,int length , IDictionary<string,int> map, string[] result, int minSumIndex , int length0,IDictionary<string,int> bothLike)
        {
            length0 = length == length0 ? 0 : length0;
            if (i < length)
            {
                if (map.ContainsKey(list[i]))
                {
                    int sum = map[list[i]] + i+length0;
                    minSumIndex = sum < minSumIndex ? sum : minSumIndex;
                    bothLike.Add(list[i], sum);
                }
                else
                {
                    map.Add(list[i], i + length0);
                }
                
            }
            return minSumIndex;
        }
       
    }
}
