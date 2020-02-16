using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution86
{

    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }    

    // creat 2 parts: left and right
    // and connect them together.
    public ListNode Partition(ListNode head, int x) {
        var leftHead = new ListNode(0);
        var leftNode = leftHead;
        var rightHead = new ListNode(0);
        var rightNode = rightHead;

        ListNode node = head;
        while (node != null)
        {
            if (node.val < x)
            {
                leftNode.next = node;
                leftNode = leftNode.next;
            }
            else
            {
                rightNode.next = node;
                rightNode = rightNode.next;
            }
            
            node = node.next;
        }

        leftNode.next = rightHead.next;
        rightNode.next = null;

        return leftHead.next;
    }
}