using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Solution1417
{
    public string Reformat(string s) {
        Stack<char> stack1 = new Stack<char>();
        Stack<char> stack0 = new Stack<char>();

        StringBuilder sb = new StringBuilder();
        
        // -1 na, 1 number, 0, a-b...z
        foreach(var c in s)
        {
            var newTag = char.IsDigit(c)? 1: 0;
            if(newTag == 1)
            {
                stack1.Push(c);
            }
            else
            {
                stack0.Push(c);
            }
        }
        
        int tag = stack0.Count > stack1.Count ? 1: 0;
        while(true)
        {
            if(tag == 1&& stack0.Any())
            {
                sb.Append(stack0.Pop());
                tag = 0;
            }
            else if(tag == 0&& stack1.Any())
            {
                sb.Append(stack1.Pop());
                tag = 1;
            }
            else
            {
                break;
            }
        }
        
        if(stack1.Any() || stack0.Any())
        {
            return string.Empty;
        }

        return sb.ToString();
    }
}