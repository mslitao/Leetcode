using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution112
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public bool HasPathSum(TreeNode root, int sum) {
        if(root == null) return false;
        return DFSHasPathSum(root, sum, 0);
    }

    public bool DFSHasPathSum(TreeNode node, int sum, int current)
    {
        if(node == null)
            return false;
        else if(node.left == null && node.right == null) 
            return sum == (current + node.val);
        else 
            return DFSHasPathSum(node.left, sum, current + node.val) || DFSHasPathSum(node.right, sum, current + node.val);
    }
}