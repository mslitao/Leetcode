using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution98
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public bool IsValidBST(TreeNode root) 
    {
        if (root == null)
        {
            return true;
        }
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode prev = null;
        while (root != null || stack.Count != 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            if (prev != null && root.val <= prev.val) return false;
            prev = root;
            root = root.right;
        }

        return true;
    }
}