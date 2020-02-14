using System;
using System.Collections.Generic;

public class Solution20
{
    public bool IsValid(string s) 
    {
        if (String.IsNullOrEmpty(s))
        {
            return true;
        }
        
        // For this kind of question related to parentheses, first choice is to try stack
        // When using stack, there are three logics
        // Push
        // Peek
        // Pop
        // Also use .Count to check if the stack is empty or not.
        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if (stack.Count > 0 &&
                (stack.Peek() == '(' && c == ')' ||
                stack.Peek() == '{' && c == '}' ||
                stack.Peek() == '[' && c == ']'))
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}