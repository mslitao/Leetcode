using System;
using System.Collections.Generic;
using System.Linq;


public class Solution114
{
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public void Flatten(TreeNode root) {
        if(root == null) return;
        Flatten(root.left);
        Flatten(root.right);

        TreeNode tmp = root.right;
        root.right = root.left;
        root.left = null;

        TreeNode node = root;
        while(node.right != null)
        {
            node = node.right;
        }

        node.right = tmp;
    }
}