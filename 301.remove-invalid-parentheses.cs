using System;
using System.Collections.Generic;
using System.Linq;


public class Solution301
{
    // BFS Solution using Queue
    public IList<string> RemoveInvalidParentheses(string s) 
    {
        IList<string> results = new List<string>();
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(s);
        bool found = false;
        while(queue.Count >0)
        {
            var current = queue.Dequeue();
            if(IsValidParenthesesByCounter(current))
            {
                results.Add(current);
                found = true;
                continue;
            }
            //if found, then there's no need to go deeper.
            if(found)
                continue;

            // Trying to remove each () once per level.
            for(int i =0; i < current.Length; ++i)
            {
                if (current[i] != '(' && current[i] != ')') continue;
                //Build the new string remove the current open or close parentheses
                var newStr = current.Substring(0, i) + current.Substring(i+1);
                if(!visited.Contains(newStr))
                {
                    visited.Add(newStr);
                    queue.Enqueue(newStr);
                }
            }
        }

        return results;
    }
    public bool IsValidParenthesesByCounter(string s)
    {
        if (String.IsNullOrEmpty(s))
        {
            return true;
        }
        
        //Check valid parentheses, use stack
        // Increase Counter by (, ++
        // Decrease Counter by ) 
        // Return false if 
            // Negative numbers of the counter in the loop
            // Non-zero counter after the loop
        int cnt = 0;
        for (int i = 0; i < s.Length; ++i) {
            if (s[i] == '(') ++cnt;
            else if (s[i] == ')' && --cnt < 0) return false;
        }
        return cnt == 0;
    }
}