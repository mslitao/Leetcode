using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution94
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<int> InorderTraversal(TreeNode root) 
    {
        List<int> values = new List<int>();

        RecurseInorderTraversal(root, values);
        return values;
    }

    public IList<int> InorderTraversalStack(TreeNode root) 
    {
        List<int> values = new List<int>();
        TreeNode node = root;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while(node != null || stack.Any())
        {
            while(node != null)
            {
                stack.Push(node);
                node = node.left;
            }

            node = stack.Pop();
            values.Add(node.val);
            node = node.right;
        }
        
        return values;
    }

    public void RecurseInorderTraversal(TreeNode node, List<int> values)
    {
        if(node == null) return;

        RecurseInorderTraversal(node.left, values);
        values.Add(node.val);
        RecurseInorderTraversal(node.right, values);
    }
}   