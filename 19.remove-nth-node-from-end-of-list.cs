using System;
using System.Collections.Generic;

public class Solution19 
{
 
    //Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    //2 pointer, and let the faster pointer start walk for n nodes
    // and then interate fast and slow pointer at the same time.
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        // Process the corner case of NULL listnode or negative n
        if (head == null || n <= 0)
        {
            return head;
        }

        ListNode node = head;
        ListNode late = head;
        int index = 0;
        while (index < n-1)
        {
            index++;
            node = node.next;
            if (node == null)
                return head;
        }

        if (node.next == null)
            return head.next;
        
        node = node.next;
        while (node.next != null)
        {
            node = node.next;
            late = late.next;
        }

        late.next = late.next.next;
        return head;
    }
}