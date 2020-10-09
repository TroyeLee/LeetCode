using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    /// 对称二叉树
    /// 给定一个二叉树，检查它是否是镜像对称的。
    /// </summary>
    public class SymmetricTree
    {
        /// <summary>
        /// 广度优先算法，分别获取每一层，判断每一层是否对称
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            bool result = false;
            if (root == null)
            {
                return true;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                IList<int?> list = new List<int?>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node == null)
                    {
                        list.Add(null);
                    }
                    if (node != null)
                    {
                        list.Add(node.val);
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }
                result = IsSymmetricList(list);
                if (!result)
                    return result;
            }


            return result;
        }

        private bool IsSymmetricList(IList<int?> list)
        {
            bool result = true;

            for (int i = 0, j = list.Count - 1; i <= j; i++, j--)
            {
                if (list[i] != list[j])
                    return false;
            }

            return result;
        }

        /// <summary>
        /// 深度优先，同时走左右子树，对比左右子树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetricDFS(TreeNode root)
        {
            bool result = check(root,root);
            
            return result;
        }
        private bool check(TreeNode left , TreeNode right)
        {
            if(left == null && right == null)
            {
                return true;
            }
            if(left==null|| right == null)
            {
                return false;
            }

            return left.val == right.val && check(left.left, right.right) && check(left.right, right.left);
        }
    }
}
