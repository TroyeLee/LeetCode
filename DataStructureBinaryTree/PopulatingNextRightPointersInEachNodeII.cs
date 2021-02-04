using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    /// 填充每个节点的下一个右侧节点指针 II
    /// 填充它的每个 next 指针，让这个指针指向其下一个右侧节点。如果找不到下一个右侧节点，则将 next 指针设置为 NULL。
    /// 初始状态下，所有 next 指针都被设置为 NULL。
    /// 
    /// 作者：力扣(LeetCode)
    /// 链接：https://leetcode-cn.com/leetbook/read/data-structure-binary-tree/xorvud/
    /// 来源：力扣（LeetCode）
    /// 著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
    /// </summary>
    public class PopulatingNextRightPointersInEachNodeII
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node node = queue.Dequeue();
                    node.next = i == size - 1 ? null : queue.Peek();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }

            return root;
        }
    }
}
