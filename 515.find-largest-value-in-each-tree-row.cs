using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution515
{
        public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public IList<int> LargestValues(TreeNode root) {
        List<int> results = new List<int>();
        if(root == null) return results;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Any())
        {
            int cnt = queue.Count;
            int maxVal = int.MinValue;
            for(int i =0; i< cnt; ++i)
            {
                var node = queue.Dequeue();
                if(node.val > maxVal) maxVal = node.val;
                
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }

            results.Add(maxVal);
        }

        return results;
    }

    public int MaxDepth(Node root) {
        if(root == null) return 0;
        int depth = 0;
        
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while(queue.Any())
        {
            depth ++;
            int cnt = queue.Count;
            for(int i =0; i< cnt; ++i)
            {
                var node = queue.Dequeue();
                if(node.children == null || node.children.Count ==0)
                    continue;

                foreach(var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        return depth;
    }
}