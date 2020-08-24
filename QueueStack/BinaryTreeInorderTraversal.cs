using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
    public class BinaryTreeInorderTraversal
    {
        /// <summary>
        /// 4.二叉树的中序遍历
        /// 给定一个二叉树，返回它的中序 遍历。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {

            IList<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if (!visited.Contains(node.right) && node.right != null)
                {
                    stack.Push(node.right);
                    visited.Add(node.right);
                }
                if (node.left == null || visited.Contains(node.left))
                {
                    result.Add(node.val);
                }
                else
                {
                    stack.Push(node);
                    if (!visited.Contains(node.left) && node.left != null)
                    {
                        stack.Push(node.left);
                        visited.Add(node.left);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 中序遍历2
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal2(TreeNode root)
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
                node = stack.Pop();
                result.Add(node.val);
                node = node.right;
            }

            return result;
        }

    }

    
    /*Definition for a binary tree node.*/
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    
}
