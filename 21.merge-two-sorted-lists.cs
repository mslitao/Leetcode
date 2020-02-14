using System;
using System.Collections.Generic;

public class Solution21
{
 
    //Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        ListNode n1 = l1;
        ListNode n2 = l2;
        ListNode n = null;
        ListNode head = null;
        while (n1 != null && n2 != null)
        {
            if (n1.val > n2.val)
            {
                if (head == null)
                {
                    head = n2;
                    n = head;
                }
                else
                {
                    n.next = n2;
                    n = n.next;
                }
                n2 = n2.next;
            }
            else
            {
                if (head == null)
                {
                    head = n1;
                    n = head;
                }
                else
                {
                    n.next = n1 ;
                    n = n.next;
                }
                n1 = n1.next;
            }
        }
        while (n1 != null)
        {
            if (head == null)
            {
                head = n1;
                n = head;
            }
            else
            {
                n.next = n1;
                n = n.next;
            }
            n1 = n1.next;
        }
        while (n2 != null)
        {
            if (head == null)
            {
                head = n2;
                n = head;
            }
            else
            {
                n.next = n2;
                n = n.next;
            }
            n2 = n2.next;
        }

        return head;
    }

    public ListNode MergeTwoLists2(ListNode l1, ListNode l2) 
    {
        if(l1 == null) return l2;
        if(l2 == null) return l1;

        ListNode head = new ListNode(1);
        ListNode node = head;
        while(l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                node.next = l1;
                l1= l1.next;
            }
            else
            {
                node.next = l2;
                l2 = l2.next;
            }
            node = node.next;
        }

        while(l1 != null)
        {
            node.next = l1;
            l1= l1.next;
            node = node.next;
        }
        while(l2 != null)
        {
            node.next = l2;
            l2= l2.next;
            node = node.next;
        }

        return head.next;
    }
}