using System;
using System.Collections.Generic;
using System.Linq;


public class Solution958
{
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public bool IsCompleteTree(TreeNode root) {
        return DFSCheckTree(root) >= 0;
    }

    public int DFSCheckTree(TreeNode root)
    {
        if(root == null)
            return 0;

        int left = DFSCheckTree(root.left);
        int right = DFSCheckTree(root.right);
        if(left == -1 || right == -1 || right > left)
        {
            return -1;
        }

        return left + right + 1;
    }

    public bool BFSCheckTree(TreeNode root)
    {
        if(root == null) return true;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool isLastLevel = false;
        while(queue.Any())
        {
            int cnt = queue.Count;
            while(cnt > 0)
            {
                var node = queue.Dequeue();
                if(isLastLevel && (node.left!= null || node.right!= null))
                {
                    return false;
                }
                if(node.left == null )
                {
                    isLastLevel = true;
                }
                else
                {
                    queue.Enqueue(node.left);
                }

                if(isLastLevel && (node.left!= null || node.right!= null))
                {
                    return false;
                }
                
                if(node.right == null)
                {
                    isLastLevel = true;
                }
                else
                {
                    queue.Enqueue(node.right);
                }
            }
        }
        
        return true;
    }
}