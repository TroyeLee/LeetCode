using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class MyLinkedList
    {

        private IList<int> data;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            data = new List<int>();
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if(data.Count==0 || index > data.Count - 1)
            {
                return -1;
            }
            return data[index];
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            data.Add(val);
            for (int i = 0; i < data.Count-1; i++)
            {
                data.Add(data[0]);
                data.RemoveAt(0);
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            data.Add(val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > data.Count)
            {
                return;
            }
            data.Add(val);
            for (int i = index; i < data.Count-1; i++)
            {
                data.Add(data[index]);
                data.RemoveAt(index);
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if(index<0 || index > data.Count - 1)
            {
                return;
            }
            data.RemoveAt(index);
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
