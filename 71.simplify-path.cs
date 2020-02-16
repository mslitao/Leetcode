using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution71
{
    /*
    Understadn each conditions which need to clean or move the path
    Leverage the string operations to remove the special cases and make the problem easier
    Leverage stack which can move back

    */
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();

        var items = path.Split('/', StringSplitOptions.RemoveEmptyEntries).Where(n => n!= ".");

        foreach(var p in items)
        {
            if(p == "..")
            {
                if(stack.Any())
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(p);
            }
        }

        //Don't forget toe reverse the stack before joining this to the string path.
        return "/"+string.Join('/', stack.Reverse());
    }
}