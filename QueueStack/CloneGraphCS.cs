using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class CloneGraphCS
    {
        Dictionary<Node, Node> marked = new Dictionary<Node, Node>();
        /// <summary>
        /// 2.克隆图
        /// 给你无向 连通 图中一个节点的引用，请你返回该图的 深拷贝（克隆）。
        /// 图中的每个节点都包含它的值 val（int） 和其邻居的列表（list[Node]）。
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node CloneGraph(Node node)
        {

            if (node == null)
            {
                return null;
            }
            // 如果该节点已经被访问过了，则直接从哈希表中取出对应的克隆节点返回
            if (marked.ContainsKey(node))
            {
                return marked[node];
            }

            Node result = new Node();

            result.val = node.val;

            marked.Add(result, node);

            for (int i = 0; i < node.neighbors.Count; i++)
            {
                result.neighbors.Add(CloneGraph(node.neighbors[i]));
            }

            return result;
        }
    }
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
