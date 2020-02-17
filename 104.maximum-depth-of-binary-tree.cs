using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution104
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public int MaxDepth(TreeNode root) 
    {
        return DFSMaxDepth(root);
    }

    public int DFSMaxDepth(TreeNode node)
    {
        if(node == null) return 0;
        return 1 + Math.Max(DFSMaxDepth(node.left), DFSMaxDepth(node.right));
    }

}