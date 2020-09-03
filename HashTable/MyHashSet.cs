using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 设计哈希集合
    /// 不使用任何内建的哈希表库设计一个哈希集合
    /// 具体地说，你的设计应该包含以下的功能
    /// add(value)：向哈希集合中插入一个值。
    /// contains(value) ：返回哈希集合中是否存在这个值。
    /// remove(value)：将给定值从哈希集合中删除。如果哈希集合中没有这个值，什么也不做。
    /// </summary>
    public class MyHashSet
    {
        private IList<int>[] data;
        private int range;
        /** Initialize your data structure here. */
        public MyHashSet()
        {
            range = 769; //range一般取一个质数
            data = new List<int>[range];
            
        }

        public void Add(int key)
        {
            int index = key % range;
            if (data[index] == null)
            {
                data[index] = new List<int>();
            }
            if (Contains(key))
            {
                return;
            }

            data[index].Add(key);

        }

        public void Remove(int key)
        {
            int index = key % range;
            if (data[index] == null || !Contains(key))
            {
                return;
            }
            data[index].Remove(key);
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int index = key % range;
            if ( data[index]!=null && data[index].Contains(key))
            {
                return true;
            }

            return false;
        }
    }
}
