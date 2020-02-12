
using System;
using System.Collections.Generic;
using System.Linq;
 
 
public class Solution2 {
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null || l2 == null)
        {
            return null;
        }

        ListNode l = null;

        ListNode n1 = l1;
        ListNode n2 = l2;
        ListNode n = l;
        int carry = 0;
        while (n1 != null || n2 != null)
        {
            var sum = carry;
            if (n1 != null )
            {
                sum += n1.val;
                n1 = n1.next;
            }
            if (n2 != null)
            {
                sum += n2.val;
                n2 = n2.next;
            }

            carry = sum/10;
            sum = sum %10;
            
            var node = new ListNode(sum);

            if (l == null)
            {
                l = node;
            }
            else
            {
                n.next = node;
            }
            n = node;

        }

        if (carry == 1)
        {
            n.next = new ListNode(1);
        }

        return l;
    }
}