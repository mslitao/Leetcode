using System;
using System.Collections.Generic;
using System.Linq;


public class Solution236
{
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || root == p || root == q) return root;

        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);
        if(left != null && right != null) return root;
        else if (left != null) return left;
        else return right;
    }
}