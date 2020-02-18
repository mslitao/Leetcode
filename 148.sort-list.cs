using System;
using System.Collections.Generic;
using System.Linq;

public class Solution148
{
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }

    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        // step 1. cut the list to two halves
        ListNode prev = null, slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        // When split the listnode, rember to set the next to null for the first half list.
        prev.next = null;

        // step 2. sort each half
        ListNode l1 = SortList(head);
        ListNode l2 = SortList(slow);

        // step 3. merge l1 and l2
        return Merge(l1, l2);
    }

    // Merge sorted list node, create the listnode 
    ListNode Merge(ListNode l1, ListNode l2)
    {
        ListNode l = new ListNode(0), p = l;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                p.next = l1;
                l1 = l1.next;
            }
            else
            {
                p.next = l2;
                l2 = l2.next;
            }
            p = p.next;
        }

        if (l1 != null)
            p.next = l1;

        if (l2 != null)
            p.next = l2;

        return l.next;
    }
}