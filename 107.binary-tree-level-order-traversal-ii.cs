using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution107
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }


    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> results = new List<IList<int>>();
        if(root == null)
        {
            return results;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var tmp = new List<int>();
            int cnt = queue.Count; // Use the count to control accessing data only in same level.
            for (int i = 0; i < cnt; ++i)
            {
                var node = queue.Dequeue();
                tmp.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            results.Add(tmp);
        }

        IList<IList<int>> newResults = new List<IList<int>>();
        for (int i = results.Count - 1; i >= 0; --i)
        {
            newResults.Add(results[i]);
        }
        return newResults;
    }
}