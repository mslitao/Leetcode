using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution10
{
    //Recursive solution
    public bool IsMatch(string s, string p)
    {
        if(string.IsNullOrEmpty(p))
        {
            return string.IsNullOrEmpty(s);
        }
        var currentMatch = !string.IsNullOrEmpty(s) && ( s[0] == p[0] || p[0] == '.');

        if (p.Length > 1 && p[1] == '*')
        {
            return IsMatch(s, p.Substring(2))
                || currentMatch && IsMatch(s.Substring(1), p);
        }
        else
        {
            return currentMatch && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}