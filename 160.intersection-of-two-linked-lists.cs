using System;
using System.Collections.Generic;
using System.Linq;

public class Solution160
{
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }

    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int length1 = 0;
        int length2 = 0;

        var cur1 = headA;
        var cur2 = headB;
        while (cur1 != null)
        {
            length1++;
            cur1 = cur1.next;
        }
        while (cur2 != null)
        {
            length2++;
            cur2 = cur2.next;
        }

        var diff = Math.Abs(length1 - length2);
        cur1 = headA;
        cur2 = headB;

        if (length1 > length2)
        {
            while (diff != 0)
            {
                diff--;
                cur1 = cur1.next;
            }
        }
        else if (length2 > length1)
        {
            while (diff != 0)
            {
                diff--;
                cur2 = cur2.next;
            }
        }

        while (cur1 != null && cur2 != null)
        {
            if (cur1 == cur2)
            {
                return cur1;
            }

            cur1 = cur1.next;
            cur2 = cur2.next;
        }

        return null;
    }
}