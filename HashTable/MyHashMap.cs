using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 设计哈希映射
    /// 不使用任何内建的哈希表库设计一个哈希映射
    /// 具体地说，你的设计应该包含以下的功能
    /// put(key, value)：向哈希映射中插入(键, 值)的数值对。如果键对应的值已经存在，更新这个值。
    /// get(key)：返回给定的键所对应的值，如果映射中不包含这个键，返回-1。
    /// remove(key)：如果映射中存在这个键，删除这个数值对。
    /// </summary>
    public class MyHashMap
    {
        //利用两个数组+列表，分别存储键-值，分别对两个列表同时操作，key值获取位置
        private IList<int>[] data_key;
        private IList<int>[] data_value;
        private int range;
        /** Initialize your data structure here. */
        public MyHashMap()
        {
            range = 769;
            data_key = new List<int>[range];
            data_value = new List<int>[range];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int index = key % range;
            if(data_key[index] == null)
            {
                data_key[index] = new List<int>();
                data_value[index] = new List<int>();
                data_key[index].Add(key);
                data_value[index].Add(value);
                return;
            }
            if (data_key[index].Contains(key))
            {
                int step = data_key[index].IndexOf(key);
                (data_value[index])[step] = value;
                return;
            }
            data_key[index].Add(key);
            data_value[index].Add(value);
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int index = key % range;
            if (data_key[index] != null && data_key[index].Contains(key))
            {
                int step = data_key[index].IndexOf(key);
                return (data_value[index])[step];
            }

            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int index = key % range;
            if (data_key[index] != null && data_key[index].Contains(key))
            {
                int step = data_key[index].IndexOf(key);
                data_key[index].RemoveAt(step);
                data_value[index].RemoveAt(step);
            }
        }
    }

    public class MyHashMap02
    {
        //利用一个键值对的类，同时存放键与值，只用一个数组链表存储，原理同MyHashSet
        public class Key_Value<K,V>
        {
            public K key;
            public V value;
            public Key_Value(K _key , V _value)
            {
                key = _key;
                value = _value;
            }
        }

        private IList<Key_Value<int, int>>[] data;
        private int range;
        /** Initialize your data structure here. */
        public MyHashMap02()
        {
            range = 769;
            data = new IList<Key_Value<int, int>>[range];

        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int index = key % range;
            if (data[index] == null)
            {
                data[index] = new List<Key_Value<int, int>>();
                data[index].Add(new Key_Value<int, int>(key,value));
                return;
            }
            int step = Contains(data[index], key);
            if(step != -1)
            {
                (data[index])[step].value = value;
            }
            else
            {
                data[index].Add(new Key_Value<int, int>(key, value));
            }
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int index = key % range;
            if(data[index] != null)
            {
                int step = Contains(data[index],key);
                return step >= 0 ? (data[index])[step].value : -1;
            }
            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int index = key % range;
            if(data[index] != null)
            {
                int step = Contains(data[index], key);
                if (step >= 0)
                {
                    data[index].RemoveAt(step);
                }
            }
        }

        private int Contains(IList<Key_Value<int,int>> list , int key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].key == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
