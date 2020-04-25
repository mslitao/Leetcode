using System;
using System.Collections.Generic;
using System.Linq;

class SolutionMock0425
{
    public string ReverseWords(string s) {
        var items = s.Split(' ');
        for(int i =0; i < items.Length; ++ i)
        {
            items[i] = ReverseWord(items[i]);
        }

        return string.Join(" ",  items);
    }
    public String ReverseWord(string str)
    {
        var chars = str.ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }

     public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public ListNode SwapPairs(ListNode head) {
        if(head == null) return head;

        ListNode h1 = new ListNode(1);
        ListNode h2 = new ListNode(1);
        ListNode n1 = h1; 
        ListNode n2 = h2;
        bool first = true;
        while(head != null)
        {
            if(first)
            {
                n1.next = head;
                n1 = n1.next;
            }
            else
            {
                n2.next = head;
                n2 = n2.next;
            }

            head = head.next;
            first = !first;
        }

        first = false;
        ListNode result = new ListNode(1);
        ListNode node = result;
        n1 = h1.next;
        n2 = h2.next;
        while(n1 != null && n2 != null)
        {
            if(first)
            {
                node.next = n1;
                n1 = n1.next;
            }
            else
            {
                node.next = n2;
                n2 = n2.next;
            }

            node = node.next;
            first = !first;
        }

        if(n1 != null)
        {
            n1.next = null;
            node.next = n1;
        }
        if(n2 != null)
        {
            n2.next = null;
            node.next = n2;
        }

        return result.next;
    }

    public IList<string> FindWords(char[][] board, string[] words) {
        List<string> results = new List<string>();
        Dictionary<char, List<Tuple<int, int>>> map = new Dictionary<char, List<Tuple<int, int>>>();
        if(board == null || words== null || words.Length == 0) return results;
        int m = board.Length;
        if(m == 0) return results;
        int n = board[0].Length;
        if(n == 0) return results;

        for(int i =0; i < m; ++i)
            for(int j =0; j < n; ++j)
            {
                if(!map.ContainsKey(board[i][j]))
                {
                    map.Add(board[i][j], new List<Tuple<int, int>>());
                }

                map[board[i][j]].Add(Tuple.Create(i, j));
            }
        
        foreach(var word in words)
        {
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
            if(DFS(map, -1, -1, 0, word, visited))
                results.Add(word);
        }

        return results;
    }

    public bool DFS(Dictionary<char, List<Tuple<int, int>>> map, int lastI, int lastJ,  int current, string word, HashSet<Tuple<int, int>> visited)
    {
        if(current == word.Length)
        {
            return true;
        }
        
        if(!map.ContainsKey(word[current]))
        {
            return false;
        }

        var posList = map[word[current]];
        foreach(var pos in posList)
        {
            if(visited.Contains(pos))
                continue;
            if(lastI == -1 && lastJ == -1 ||
               pos.Item1 == lastI + 1 && pos.Item2 == lastJ ||
               pos.Item1 == lastI - 1 && pos.Item2 == lastJ || 
               pos.Item1 == lastI && pos.Item2 == lastJ + 1 ||
               pos.Item1 == lastI && pos.Item2 == lastJ - 1)
            {
                visited.Add(pos);
                if(DFS(map, pos.Item1, pos.Item2,  current + 1, word, visited) == true) return true;
                visited.Remove(pos);
            }
        }
        
        return false;
    }

    public ListNode MiddleNode(ListNode head) {
        if(head == null) return null;
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null )
        {
            fast = fast.next;
            if(fast != null )
            {
                fast = fast.next;
            }
            else
            {
                break;
            }
            slow = slow.next;
        }

        return slow;
    }

    public bool CanJump(int[] nums) {
        int size = nums.Length;
        if(size == 0) return true;
        int reach = 0;
        for(int i = 0; i < size; ++i)
        {
            if(reach < i || reach >= size -1) break;
            reach = Math.Max(reach, i + nums[i]);
        }
        return reach >= size-1;
    }
    
}