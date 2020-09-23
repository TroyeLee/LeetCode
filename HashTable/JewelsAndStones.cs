using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 宝石与石头
    /// 给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。
    /// S 中每个字符代表了一种你拥有的石头的类型，你想知道你拥有的石头中有多少是宝石。
    /// J 中的字母不重复，J 和 S中的所有字符都是字母。字母区分大小写，因此"a"和"A"是不同类型的石头。
    /// </summary>
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int result = 0;
            IDictionary<char, int> map = new Dictionary<char, int>();
            if (J.Length == 0 || S.Length == 0)
                return result;
            foreach (var item in S)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            foreach (var item in J)
            {
                if (map.ContainsKey(item))
                {
                    result += map[item];
                }
            }

            return result;
        }

        public int NumJewelsInStones02(string J, string S)
        {
            int result = 0;
            HashSet<char> Set = new HashSet<char>();
            if (J.Length == 0 || S.Length == 0)
                return result;
            foreach (var item in J)
            {
                if(!Set.Contains(item))
                    Set.Add(item);
            }
            foreach (var item in S)
            {
                if (Set.Contains(item))
                    result++;
            }

            return result;
        }
    }
}
