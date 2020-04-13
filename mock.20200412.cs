using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Mock20200412
{

    public bool Search(int[] nums, int target) {
        if(nums == null || nums.Length == 0) return false;

        return BinarySearch(nums, 0, nums.Length -1 , target);
    }

    public bool BinarySearch(int[] nums, int left, int right, int target)
    {
        if(right< left) return false;
        if(left == right ) return nums[left] == target;

        int middle = left + (right - left) / 2;
        if(nums[middle] == target) return true;
        else if (nums[middle] < target) 
        {
            return BinarySearch(nums, middle + 1, right, target) ||
            (nums[left] >= nums[right] && BinarySearch(nums, left, middle - 1, target));
        }
        else
        {
            return BinarySearch(nums, left, middle - 1, target) ||
            (nums[left] >= nums[right] && BinarySearch(nums, middle + 1, right, target));
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
 

    public bool IsCousins(TreeNode root, int x, int y) {
        if(root == null ) return false;
        if(x == y) return false;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Any())
        {
            int len = queue.Count;
            bool findX = false;
            bool findY = false;
            for(int i = 0; i < len; ++i)
            {
                var node = queue.Dequeue();
                if(node.val == x) findX = true;
                if(node.val == y) findY = true;

                if(node.left != null && node.left.val == x && node.right != null && node.right.val == y)
                {
                    return false;
                }

                
                if(node.left != null && node.left.val == y && node.right != null && node.right.val == x)
                {
                    return false;
                }

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            if(findX && findY)
                return true;
            
        }
        return false;
    }
    
}