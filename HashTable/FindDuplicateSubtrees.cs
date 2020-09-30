using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 寻找重复的子树
    /// 给定一棵二叉树，返回所有重复的子树。对于同一类的重复子树，
    /// 你只需要返回其中任意一棵的根结点即可。
    /// 两棵树重复是指它们具有相同的结构以及相同的结点值。
    /// 示例 1：
    ///         1
    ///        / \
    ///       2   3
    ///      /   / \
    ///     4   2   4
    ///        /
    ///       4
    ///   下面是两个重复的子树：
    ///   2
    ///  /
    /// 4
    /// 和
    /// 4
    /// 因此，你需要以列表的形式返回上述重复子树的根结点。
    /// </summary>
    public class FindDuplicateSubtreesCS
    {
        IList<TreeNode> result;
        IDictionary<string, int> map;
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            result = new List<TreeNode>();
            map = new Dictionary<string, int>();
            collect(root);
            return result;
        }

        private string collect(TreeNode node)
        {
            if (node == null)
            {
                return "#";
            }

            string Key = node.val + "," + collect(node.left) + "," + collect(node.right);

            if (map.ContainsKey(Key))
            {
                map[Key]++;
                if (map[Key] == 2)
                {
                    result.Add(node);
                }
            }
            else
            {
                map.Add(Key, 1);
            }

            return Key;
        }

    }
}
