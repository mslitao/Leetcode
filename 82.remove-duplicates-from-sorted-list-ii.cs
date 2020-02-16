using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution82
{

    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }    

    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummy = new ListNode(int.MinValue);
        dummy.next = head;
            
        ListNode pre = dummy;
        while(pre.next != null)
        {
            ListNode cur = pre.next;

            while(cur.next != null && cur.next.val == cur.val)
            {
                cur = cur.next;
            }

            if(cur == pre.next)
            {
                pre = pre.next;
            }
            else
            {
                pre.next = cur.next;
            }
        }
        return dummy.next;
    }
}
