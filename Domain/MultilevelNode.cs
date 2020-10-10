using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Domain
{
    /// <summary>
    /// 多级双向链表节点
    /// </summary>
    public class MultilevelNode
    {
        public int? val;
        public MultilevelNode prev;
        public MultilevelNode next;
        public MultilevelNode child;
        public MultilevelNode(int? _val,MultilevelNode _prev)
        {
            val = _val;
            prev = _prev;
            next = null;
            child = null;
        }
        public MultilevelNode(int? _val)
        {
            val = _val;
            prev = null;
            next = null;
            child = null;
        }
        public MultilevelNode() { }
    }
}
