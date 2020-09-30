using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    /// 二叉树的前序遍历
    /// 给定一个二叉树，返回它的 前序 遍历。
    /// </summary>
    public class BinaryTreePreorderTraversal
    {
        IList<int> result;
        /// <summary>
        /// 递归法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            result = new List<int>(); 
            if (root == null)
            {
                return result;
            }
            getNum(root);
            return result;
        }

        private void getNum(TreeNode node)
        {
            if (node == null)
                return;
            result.Add(node.val);
            getNum(node.left);
            getNum(node.right);
        }


        /// <summary>
        /// 迭代法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal2(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                result.Add(node.val);
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }

            return result;
        }
    }
}
