using System;
using System.Collections.Generic;
using System.Linq;

public class SolutionMock0523 
{
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        //BFS, return the min depth when reach at the leaf.

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int level = 0;
        while(queue.Any())
        {
            level ++;
            int len = queue.Count;
            for(int i = 0; i < len; ++i)
            {
                var node = queue.Dequeue();
                if(node.left == null && node.right == null)
                    return level;
            
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
        }

        return level;
    }

    private Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    public SolutionMock0523(int[] nums) {
        for(int i = 0; i < nums.Length; ++i)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], new List<int>());
            }

            map[nums[i]].Add(i);
        }
    }
    
    public int Pick(int target) {
        var list = map[target];
        if(list.Count == 1) return  list[0];

        int idx = new Random().Next(list.Count);
        return list[idx];
    }
}