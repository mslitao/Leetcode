using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution102
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> results = new List<IList<int>>();
        if(root == null) return results;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Any())
        {
            var size = queue.Count();
            IList<int> currents = new List<int>();
            for(int i =0; i < size; ++i)
            {
                var node = queue.Dequeue();
                currents.Add(node.val);
                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                
                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            results.Add(currents);
        }
        return results;
    }
}