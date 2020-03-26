using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution337
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public int Rob(TreeNode root) {
        var result = DFSRob(root);
        return Math.Max(result.Item1, result.Item2);
    }

    public Tuple<int, int> DFSRob(TreeNode root)
    {
        if(root == null) return Tuple.Create(0, 0);

        var leftVal = DFSRob(root.left);
        var rightVal = DFSRob(root.right);

        int rob = leftVal.Item2 + rightVal.Item2 + root.val;
        int skip = Math.Max(leftVal.Item1, leftVal.Item2) + Math.Max(rightVal.Item1, rightVal.Item2);

        return Tuple.Create(rob, skip);
    }
}