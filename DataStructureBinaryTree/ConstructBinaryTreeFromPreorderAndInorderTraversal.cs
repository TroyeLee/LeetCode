using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    /// 从前序与中序遍历序列构造二叉树
    /// 根据一棵树的前序遍历与中序遍历构造二叉树。
    /// 注意:
    /// 你可以假设树中没有重复的元素。
    /// 例如
    /// 前序遍历 preorder = [3,9,20,15,7]
    /// 中序遍历 inorder = [9, 3, 15, 20, 7]
    /// </summary>
    public class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        int preIndex;
        int[] _preorder;
        IDictionary<int, int> map = new Dictionary<int, int>();

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length != inorder.Length)
            {
                return null;
            }
            TreeNode root;
            preIndex = 0;
            _preorder = preorder;
            int val = 0;
            foreach (var item in inorder)
            {
                map.Add(item, val++);
            }
            root = helper(0,inorder.Length-1);
            return root;
        }

        private TreeNode helper(int left_index , int right_index)
        {
            if (left_index > right_index)
            {
                return null;
            }

            int root_val = _preorder[preIndex];
            TreeNode root = new TreeNode(root_val);
            int inIndex = map[root_val];
            preIndex++;
            root.left = helper(left_index, inIndex - 1);
            root.right = helper(inIndex + 1, right_index);

            return root;

        }
    }
}
