using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructureBinaryTree
{
    /// <summary>
    /// 从中序与后序遍历序列构造二叉树
    /// 根据一棵树的中序遍历与后序遍历构造二叉树。
    /// 你可以假设树中没有重复的元素。
    /// 中序遍历 inorder = [9,3,15,20,7]
    /// 后序遍历 postorder = [9, 15, 7, 20, 3]
    /// </summary>
    public class ConstructBinaryTreeFromInorderAndPostorderTraversal
    {
        int postIndex;
        int[] _postorder;
        IDictionary<int, int> map = new Dictionary<int,int>();

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if(inorder.Length != postorder.Length)
            {
                return null;
            }
            TreeNode root;
            postIndex = postorder.Length - 1;
            _postorder = postorder;

            int val = 0;
            foreach (var item in inorder)
            {
                map.Add(item, val++);
            }
            root = helper(0, inorder.Length - 1);
            return root;
        }
        /// <summary>
        /// 根据后序遍历，可以获得根节点，然后根据这个根节点可以在中序遍历中分割左右子树，先生成右子树，再生成左子树
        /// </summary>
        /// <param name="left_index"></param>
        /// <param name="right_index"></param>
        /// <returns></returns>
        private TreeNode helper(int left_index,int right_index)
        {
            if (left_index > right_index)
            {
                return null;
            }
            int root_val = _postorder[postIndex];
            int inIndex = map[root_val];
            TreeNode root = new TreeNode(root_val);

            postIndex--;
            root.right = helper(inIndex + 1, right_index);  //注意先进行右子树的生成，因为后序遍历是左右中，所以此根节点先可能是上一个节点的右子树节点。
            root.left = helper(left_index, inIndex - 1);


            return root;
        }
    }
}
