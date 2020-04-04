using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution543
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public int DiameterOfBinaryTree(TreeNode root) {
        int maxLength = 0;
        DFSMaxPath(root, ref maxLength);

        if(maxLength > 0) maxLength--;
        return maxLength;
    }
    
    public int DFSMaxPath(TreeNode root, ref int max)
    {
        if(root==null) return 0;
        
        int maxLeft = DFSMaxPath(root.left, ref max);
        int maxRight = DFSMaxPath(root.right, ref max);

        max = Math.Max(max, maxLeft + maxRight + 1);
        return Math.Max(maxLeft, maxRight) + 1;
    }
}