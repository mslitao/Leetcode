using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution133
{
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> neighbors;
        
        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }
        
        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public Node CloneGraph(Node node) {
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        return DFSCloneGraph(node, map);
    }

    public Node DFSCloneGraph(Node node, Dictionary<Node, Node> map) 
    {
        if(node == null) return null;

        if(map.ContainsKey(node)) return map[node];
        
        var newNode = new Node(node.val);
        map.Add(node, newNode);

        foreach(var nb in node.neighbors)
        {
            var newNb = DFSCloneGraph(nb, map);
            newNode.neighbors.Add(newNb);
        }
        return newNode;
    }
}