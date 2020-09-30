using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    ///二叉树的后序遍历
    ///给定一个二叉树，返回它的 后序 遍历。
    /// </summary>
    public class BinaryTreePostorderTraversal
    {
        IList<int> result;
        /// <summary>
        /// 递归法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            result = new List<int>();

            BuildList(root);

            return result;
        }

        private void BuildList(TreeNode node)
        {
            if (node == null)
                return;
            BuildList(node.left);
            BuildList(node.right);
            result.Add(node.val);

        }

        /// <summary>
        /// 迭代法1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal2(TreeNode root)
        {
            IList<int> result = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
            TreeNode node = root;
            stack.Push(node);

            while (stack.Count > 0)
            {
                node = stack.Peek();
                if(node.left == null || visited.Contains(node.left))
                {
                    if(node.right == null || visited.Contains(node.right))
                    {
                        node = stack.Pop();
                        visited.Add(node);
                        result.Add(node.val);
                    }
                    else
                    {
                        stack.Push(node.right);
                    }
                }
                else
                {
                    stack.Push(node.left);
                }
            }

            return result;
        }

        /// <summary>
        /// 递归法2
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal3(TreeNode root)
        {
            IList<int> result = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || stack.Count > 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                node = stack.Peek().right;
                if(node == null)
                {
                    node = stack.Pop();
                    result.Add(node.val);
                }
            }

            return result;
        }
    }
}
