using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution559
{
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }

    public int MaxDepth(Node root) {
        if(root == null) return 0;
        int depth = 0;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while(queue.Any())
        {
            depth ++;
            int cnt = queue.Count;
            for(int i =0; i< cnt; ++i)
            {
                var node = queue.Dequeue();
                if(node.children == null || node.children.Count ==0)
                    continue;

                foreach(var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        return depth;
    }
}