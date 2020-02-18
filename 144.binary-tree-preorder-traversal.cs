using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution144
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> results = new List<int>();
        PreorderTraversal(root, results);
        return results;
    }

    public void PreorderTraversal(TreeNode node, IList<int> results)
    {
        if (node == null) return;
        results.Add(node.val);
        PreorderTraversal(node.left, results);
        PreorderTraversal(node.right, results);
    }
}