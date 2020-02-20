using System;
using System.Collections.Generic;
using System.Linq;

public class Solution257
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> paths = new List<string>();

        RecurseVisit(root, paths, new List<int>());

        return paths;        
    }

    public void RecurseVisit(TreeNode node, List<string> paths, List<int> current)
    {
        if(node == null) return;

        if(node.left == null && node.right == null){
            current.Add(node.val);
            paths.Add(string.Join("->", current));
            current.RemoveAt(current.Count-1);
            return;
        }

        current.Add(node.val);
        RecurseVisit(node.left, paths, current);
        RecurseVisit(node.right, paths, current);
        current.RemoveAt(current.Count-1);
        return;
    }
}