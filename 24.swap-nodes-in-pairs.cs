using System;
using System.Collections.Generic;

public class Solution24
{
 
    //Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public ListNode SwapPairs(ListNode head) 
    {
        ListNode result = new ListNode(0);
        ListNode current = head;
        ListNode node = result;
        while (true)
        {
            ListNode n1 = current;
            if (n1 == null)
            {
                break;
            }
            ListNode n2 = current.next;
            if (n2 == null)
            {
                node.next = n1;
                break;
            }
            else
            {
                
                var tmp = n2.next;
                n2.next = n1;
                node.next = n2;
                node = n1;
                node.next = null;
                current = tmp;
            }
            
        }

        return result.next;
    }
}