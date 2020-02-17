using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution113
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        IList<IList<int>> results = new List<IList<int>>();
        IList<int> values = new List<int>();
        DFSPathSum(root, sum, 0, values, results);

        return results;
    }

    public void DFSPathSum(TreeNode node, int target,  int sum, IList<int> values, IList<IList<int>> results)
    {
        if(node == null)
        {
            return;
        }

        if(node.left == null && node.right == null)
        {
            if(sum + node.val == target)
            {
                var res = values.Select(n=>n).ToList();
                res.Add(node.val);
                results.Add(res);
            }
            return;
        }

        var newValues = new List<int>(values);
        newValues.Add(node.val);
        DFSPathSum(node.left, target, sum + node.val, newValues, results);
        DFSPathSum(node.right, target, sum + node.val, newValues, results);
    }
}