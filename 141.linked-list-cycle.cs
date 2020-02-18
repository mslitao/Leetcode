using System;
using System.Collections.Generic;
using System.Linq;

public class Solution141
{
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }

    public bool HasCycle(ListNode head) {
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
}