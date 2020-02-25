using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution100
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        return (p == null && q == null) ||
                (p != null && q != null && p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
    }
}