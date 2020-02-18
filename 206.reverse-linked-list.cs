using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution206
{
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null || head.next == null)
                return head;
            ListNode newHead = null;
            ListNode node = head;
            while(node != null)
            {
                var temp = node.next;
                node.next = newHead;
                newHead = node;
                node = temp;
            }
        return newHead;
    }
}