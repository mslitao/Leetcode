using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution110
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public bool IsBalanced(TreeNode root) {
        return DFSTree(root) >=0;
    }

    public int DFSTree(TreeNode root) 
    {
        if(root == null) return 0;
        
        var left =0;
        if(root.left != null )
        {
            left = DFSTree(root.left);
            if(left < 0) return left;
            left ++;
        }
        var right =0;
        if(root.right != null)
        {
            right = DFSTree(root.right);
            if(right< 0) return right;
            right ++;
        }
        if(left >=0 && right >=0 && Math.Abs(left - right) <= 1) return Math.Max(left, right);
        else return -1;
    }
}