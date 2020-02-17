using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution111
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public int MinDepth(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        int depth = 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            depth++;
            int cnt = queue.Count;
            for (int i = 0; i < cnt; ++i)
            {
                var node = queue.Dequeue();
                //If meet one leaf node, just return results at this level.
                if (node.left == null && node.right == null)
                {
                    return depth;
                }

                // Continue BFS on left and right child and add them into the queue.
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        return depth;
    }
}