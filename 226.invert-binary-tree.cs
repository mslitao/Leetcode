using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution226
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public TreeNode InvertTree(TreeNode root) {
        //BFS visit and 
        BFSInvertTree(root);
        return root;
    }

    public void BFSInvertTree(TreeNode node)
    {
        if(node == null)
            return;
        
        var temp = node.left;
        node.left = node.right;
        node.right = temp;

        BFSInvertTree(node.left);
        BFSInvertTree(node.right);
    }
}
