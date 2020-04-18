public class Solution328 {
        public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
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
        
        nodd.next = heven.next;
        neven.next = null;
        return hodd.next;
    }
}