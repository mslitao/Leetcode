
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution61 {

    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
    }
    }    
    
    ListNode RotateRight(ListNode head, int k) {
        return null;
    }

    /* C++
    ListNode* rotateRight(ListNode* head, int k) {
        if(!head) return head;
        
        int len=1; // number of nodes
        ListNode *newH, *tail;
        newH=tail=head;
        
        while(tail->next)  // get the number of nodes in the list
        {
            tail = tail->next;
            len++;
        }
        tail->next = head; // circle the link

        if(k %= len) 
        {
            for(auto i=0; i<len-k; i++) tail = tail->next; // the tail node is the (len-k)-th node (1st node is head)
        }
        newH = tail->next; 
        tail->next = NULL;
        return newH;
    }
    */
}