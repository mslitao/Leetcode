using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1047
{
    public string RemoveDuplicates(string S) {
        if(string.IsNullOrEmpty(S)) return S;
        Stack<char> stack = new Stack<char>();
        foreach(var c in S)
        {
            bool duplicated = false;
            while(stack.Any() && stack.Peek() == c)
            {
                stack.Pop();
                duplicated = true;
            }

            if(!duplicated) stack.Push(c);
        }

        return string.Join("", stack.Reverse());
    }
}