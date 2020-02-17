using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution106
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return RecursiveBuildTreeNode(inorder.ToList(), postorder.ToList());
    }

    public TreeNode RecursiveBuildTreeNode(List<int> inorder, List<int> postorder)
    {
        if(postorder == null || postorder.Count ==0 ) return null;

        var val = postorder.Last();
        var index = inorder.IndexOf(val);
        
        TreeNode node = new TreeNode(val);

        node.left = RecursiveBuildTreeNode(inorder.GetRange(0, index), 
                                           postorder.GetRange(0, index));
        node.right = RecursiveBuildTreeNode(inorder.GetRange(index + 1, postorder.Count - index - 1),
                                            postorder.GetRange(index, postorder.Count - index - 1));
                                            
        return node;
    }
}