using System;
using System.Collections.Generic;

public class Solution23
{
 
    //Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public ListNode MergeKLists(ListNode[] lists) {
        int len = lists.Length;
        if(len == 0) return null;
        if(len == 1) return lists[0];
        
        ListNode head = new ListNode(-1);
        var node = head;
        while(true)
        {
            int minValue = int.MaxValue;
            int minIndex = -1;
            for(int i =0; i < len; ++i)
            {
                if(lists[i] != null && lists[i].val < minValue)
                {
                    minValue = lists[i].val;
                    minIndex = i;

                }
            }

            if(minIndex == -1)
            {
                break;
            }
            else
            {
                node.next = lists[minIndex];
                lists[minIndex] = lists[minIndex].next;
                node = node.next;
            }
        }

        return head.next;
    }
}