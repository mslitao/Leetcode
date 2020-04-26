using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1080
{
    
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public TreeNode SufficientSubset(TreeNode root, int limit) {
        if(root == null) return null;
        var result = DFS(root, 0, limit);

        if(result)
        {
            return root;
        }
        else
        {
            return null;
        }
    }

    public bool DFS(TreeNode root, int current,  int limit)
    {
        current += root.val;
        if(root.left == null && root.right == null)
        {
            return current >= limit;
        }
        
        var checkL = root.left == null? false: DFS(root.left, current, limit);
        var checkR = root.right == null? false: DFS(root.right, current, limit);
        if(!checkL)
        {
            root.left = null;
        }

        if(!checkR)
        {
            root.right = null;
        }
        
        return checkL || checkR;
    }
}