using System;
using System.Collections.Generic;
using System.Linq;

public class Solution138
{
    public class Node 
    {
        public int val;
        public Node next;
        public Node random;
        
        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }
    }

    // Use a dictionary to map the old node and new copied node. 
    // DO one round of copying of the LinkedList.
    // Do one more round of copying of random pointer.
    public Node CopyRandomList(Node head) 
    {
        Node copiedHead = new Node(-1);
        Node node = head;
        Node copiedNode = copiedHead;
        Dictionary<Node, Node> randomMapping = new Dictionary<Node, Node>();
        while(node != null)
        {
            var newNode = new Node(node.val);
            newNode.next = null;
            copiedNode.next = newNode;

            randomMapping.Add(node, newNode);

            copiedNode = copiedNode.next;
            node = node.next;
        }

        copiedNode = copiedHead.next;
        node = head;
        while(node != null)
        {
            if(node.random == null)
            {
                copiedNode.random = null;
            }
            else
            {
                copiedNode.random = randomMapping[node.random];
            }
            copiedNode = copiedNode.next;
            node = node.next;
        }

        return copiedHead.next;
    }
}