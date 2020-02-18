using System;
using System.Collections.Generic;
using System.Linq;

public class Solution143
{
    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; 
        }
    }

    public void ReorderList(ListNode head) {
         if(head == null || head.next == null) return;
        //left side has (n + 1)/2
        //right side has n/2
        // reverse the second part first.
        int length = 0;
        var node = head;
        while(node != null)
        {
            node = node.next;
            length ++;
        }
        
        int right = length /2;
        int left = length - right;
        
        var rightNode = head;
        
        length =0;
        while(rightNode != null)
        {
            length ++;
            rightNode = rightNode.next;
            
            if(length == left)
            { 
                break;
            }
        }
        //Console.WriteLine(rightNode.val);
        ListNode rightHead = ReverseListNode(rightNode);
        ListNode leftHead = head;
        
        ListNode resultHead = new ListNode(0);
        ListNode resultNode = resultHead;
        //Console.WriteLine(left);
        //Console.WriteLine(right);

        /*ListNode tmp = rightHead;
        while(tmp != null)
        {
            Console.Write(tmp.val);
            tmp = tmp.next;
        }
        Console.WriteLine("---------------------");

        tmp = leftHead;
        while(tmp != null)
        {
            Console.Write(tmp.val);
            tmp = tmp.next;
        }
        //Console.WriteLine("---------------------");*/

        while(left >0 && right >0)
        {
            //Console.WriteLine("---------------------");
            left --;
            right --;
            
            var tmpL = leftHead.next;
            var tmpR = rightHead.next;
            resultNode.next = leftHead;
            resultNode = resultNode.next;
            
            //Console.WriteLine(leftHead.val);
            resultNode.next = rightHead;
            resultNode = resultNode.next;
            //Console.WriteLine(rightHead.val);
            
            leftHead = tmpL;
            rightHead = tmpR;
        }
        //Console.WriteLine(left);
        //Console.WriteLine(right);
        if(left==1)
        {
            resultNode.next = leftHead;
            resultNode = resultNode.next;
        }
        resultNode.next = null;

        head = resultHead.next;
    }

    public ListNode ReverseListNode(ListNode head)
    {
        if(head == null || head.next == null)
            return head;
        ListNode newHead = null;
        ListNode node = head;
        while(node != null)
        {
            var temp = node.next;
            node.next = newHead;
            newHead = node;
            node = temp;
        }

        return newHead;
    }
}