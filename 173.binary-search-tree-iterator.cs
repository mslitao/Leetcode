using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution173 {
    //Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BSTIterator {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode next = null;
        public BSTIterator(TreeNode root) {
            next = root;
        }
        
        /** @return the next smallest number */
        public int Next() {
            int res = int.MinValue;
            if(next != null || stack.Any())
            {
                while(next != null)
                {
                    stack.Push(next);
                    next = next.left;
                }
                next = stack.Pop();
                res = next.val;
                next = next.right;
            }
            
            return res;
        }
        
        /** @return whether we have a next smallest number */
        public bool HasNext() {
            return next != null || stack.Any();
        }
    }

}