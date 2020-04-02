using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution124 {
    //Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public int MaxPathSum(TreeNode root) {
        int maxSum = root.val;
        DFSMaxPathSum(root, ref maxSum);
        return maxSum;
    }

    public int DFSMaxPathSum(TreeNode root, ref int maxSum) {
        if(root == null) return -10000;
        
        var current = root.val;
        Console.WriteLine(current);
        
        var maxLeft = DFSMaxPathSum(root.left, ref maxSum);
        var maxRight = DFSMaxPathSum(root.right, ref maxSum);

        int sum = current;
        if(sum + maxLeft > sum) sum += maxLeft;
        if(sum + maxRight > sum) sum += maxRight;
        
        Console.WriteLine(sum);
        if(sum > maxSum) maxSum = sum;
        
        return Math.Max(current, Math.Max(maxLeft, maxRight) + current);
    }
}
