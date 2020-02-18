using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution145
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> results = new List<int>();
        PostorderTraversal(root, results);
        return results;
    }

    public void PostorderTraversal(TreeNode node, IList<int> results)
    {
        if (node == null) return;
        
        PostorderTraversal(node.left, results);
        PostorderTraversal(node.right, results);
        results.Add(node.val);
    }
}