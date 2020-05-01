using System;
using System.Collections.Generic;
using System.Linq;

public class Mock0429
{
    public int FindSecondMinimumValue(TreeNode root) {
        int minVal = root.val;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int result = int.MaxValue;
        bool found = false;
        while(queue.Any())
        {
            var node = queue.Dequeue();
            if(node.val == minVal)
            {
                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            else if(node.val > minVal) 
            {
                result = Math.Min(result, node.val);
                found = true;
            }
        }


        return found? result: -1;
    }
}