using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    /// 路径总和
    /// 给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，
    /// 这条路径上所有节点值相加等于目标和。
    /// 说明: 叶子节点是指没有子节点的节点。
    /// </summary>
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if(root == null)
            {
                return false;
            }
            return Check(root, sum - root.val);
        }
        private bool Check(TreeNode root, int sum)
        {
            if (root.left == null && root.right == null)
            {
                return sum == 0;
            }
            bool leftPath = false;
            bool rightPath = false;
            if (root.left!=null)
                leftPath = Check(root.left, sum - root.left.val);
            if(root.right!=null)
                rightPath = Check(root.right, sum - root.right.val);

            return leftPath || rightPath;
        }
    }
}
