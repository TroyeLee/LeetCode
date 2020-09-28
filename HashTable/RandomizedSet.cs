using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 常数时间插入、删除和获取随机元素
    /// 设计一个支持在平均 时间复杂度 O(1) 下，执行以下操作的数据结构。
    /// insert(val)：当元素 val 不存在时，向集合中插入该项。
    /// remove(val)：元素 val 存在时，从集合中移除该项。
    /// getRandom：随机返回现有集合中的一项。每个元素应该有相同的概率被返回。
    /// </summary>
    public class RandomizedSet
    {

        /** Initialize your data structure here. */
        
        IDictionary<int, int> value_index;
        IList<int> data;
        public RandomizedSet()
        {
            value_index = new Dictionary<int, int>();
            data = new List<int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (value_index.ContainsKey(val))
            {
                return false;
            }
            value_index.Add(val, data.Count);
            data.Add(val);
            return true;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!value_index.ContainsKey(val)||data.Count==0)
            {
                return false;
            }
            if (data.Count == 1) {
                value_index.Remove(val);
                data.RemoveAt(0);
                return true;
            }
            int index = value_index[val];
            value_index.Remove(val);

            int last_index = data.Count - 1;
            if (index == last_index)
            {
                data.RemoveAt(last_index);
                return true;
            }

                int last_val = data[last_index];
            value_index[last_val] = index;            // 将最后一位替换到remove的位置

            data[index] = last_val; // 将最后一位替换到remove的位置
            data.RemoveAt(last_index);               // remove最后一位

            return true;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            if (data.Count == 0)
            {
                return -1;
            }
            int index = new Random().Next(0,data.Count);
            return data[index];
        }
    }
}
