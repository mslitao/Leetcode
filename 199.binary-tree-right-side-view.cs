using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution199
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<int> RightSideView(TreeNode root) {
        // BFS, and get last one in each level
        List<int> results = new List<int>();
        if(root == null) return results;
        Queue<TreeNode> stack = new Queue<TreeNode>();
        stack.Enqueue(root);

        while(stack.Any())
        {
            int cnt = stack.Count;
            while(cnt >0)
            {
                var node = stack.Dequeue();
                if(node.left!=null) stack.Enqueue(node.left);
                if(node.right != null) stack.Enqueue(node.right);

                cnt --;
                if(cnt == 0)
                {
                    results.Add(node.val);
                }
            }
        }

        return results;
    }

}