using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5418
{
    private int result = 0;
    public int PseudoPalindromicPaths (TreeNode root) {
        if(root == null) return 0;
        int[] map = new int[10];
        DFS(root, map);

        return this.result;
    }

    // DFS
    public void DFS(TreeNode node, int[] current)
    {
        current[node.val] ++;
        if(node.left == null && node.right == null)
        {
            int singleCnt = 0;
            foreach(var cnt in current)
            {
                if(cnt % 2 == 1) singleCnt ++;
            }

            if(singleCnt <=1) this.result ++;
        }

        if(node.left != null) DFS(node.left, current);
        if(node.right!= null) DFS(node.right, current);
        current[node.val] --;
    }
}