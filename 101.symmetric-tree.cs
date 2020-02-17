using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution101
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        return RecursiveIsSymmetric(root.left, root.right);
    }

    public bool RecursiveIsSymmetric(TreeNode left, TreeNode right)
    {
        if(left == null && right == null) return true;
        else if(left == null || right == null) return false;
        else
        {
            return left.val == right.val &&
                   RecursiveIsSymmetric(left.left, right.right) &&
                   RecursiveIsSymmetric(left.right, right.left);
        }
    }
}