using System;
using System.Collections.Generic;


class SolutionMock0417
{
    
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public ListNode DetectCycle(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;

        while(fast != null && fast.next != null && slow != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if(fast == slow)
                break;
        }
        if(fast == null || fast.next == null) return null;
        
        slow = head;
        while(slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        return slow;
    }

    public ListNode OddEvenList(ListNode head) {
        if(head == null) return null;

        ListNode hodd = new ListNode(-1);
        ListNode nodd = hodd;
        ListNode heven = new ListNode(-1);
        ListNode neven = heven;

        ListNode node = head;
        int idx = 1;
        while(node != null)
        {
            //Console.WriteLine(node.val);
            if(idx % 2 ==0)
            {
                neven.next = node;
                neven = neven.next;
            }
            else
            {
                nodd.next = node;
                nodd = nodd.next;
            }
            node = node.next;
            idx++;
        }
        /*Console.WriteLine(neven.val);
        Console.WriteLine(nodd.val);
        
        Console.WriteLine(heven.next.val);*/
        nodd.next = heven.next;
        neven.next = null;
        return hodd.next;
    }
}