using System;
using System.Collections.Generic;
using System.Linq;

public class Solution142
{
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }

    public bool HasCycle(ListNode head) 
    {
        if(head == null || head.next == null) return false;
        var slow = head;
        var fast = head.next;
        while(slow != fast)
        {
            if(fast == null || fast.next == null)
                return false;
            slow = slow.next;
            fast = fast.next.next;
        }

        return true;
    }

    public ListNode DetectCycle(ListNode head) 
    {
        if(head == null) return null;
        var slow = head;
        var fast = head;
        while(fast != null && fast.next !=null)
        {   
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) break;
        }

        if(fast == null || fast.next == null)
            return null;

        slow = head;
        while(slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }

        return fast;
    }
}