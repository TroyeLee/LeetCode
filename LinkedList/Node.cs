using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    /// <summary>
    /// 多级双向链表节点
    /// </summary>
    public class Node
    {
        public int? val;
        public Node prev;
        public Node next;
        public Node child;
        public Node(int? _val,Node _prev)
        {
            val = _val;
            prev = _prev;
            next = null;
            child = null;
        }
        public Node(int? _val)
        {
            val = _val;
            prev = null;
            next = null;
            child = null;
        }
        public Node() { }
    }
}
