using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution10
{
    //Recursive solution
    public bool IsMatch(string s, string p)
    {
        // if the regex is empty, the source string should also be empty 
        if(string.IsNullOrEmpty(p))
        {
            return string.IsNullOrEmpty(s);
        }
        var currentMatch = !string.IsNullOrEmpty(s) && ( s[0] == p[0] || p[0] == '.');

        // if next char in regex is char which means 2 conditions
        // 1. * is zero, don't match .* and continue to match rest of patterns
        // 2. match the current char, and continue use the .*
        if (p.Length > 1 && p[1] == '*')
        {
            return IsMatch(s, p.Substring(2))
                || currentMatch && IsMatch(s.Substring(1), p);
        }
        else
        {
            // if the next char is not *
            // make sure current match and move both string and regex to next position
            return currentMatch && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}