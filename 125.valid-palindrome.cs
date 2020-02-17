using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution125
{
    public bool IsPalindrome(string s) {
        if ( string.IsNullOrEmpty(s))
        {
            return true;
        }

        int head = 0, tail = s.Length - 1;
        while (head <= tail)
        {
            char cHead = s[head];
            char cTail = s[tail];
            if (!Char.IsLetterOrDigit(cHead))
            {
                head++;
            }
            else if (!Char.IsLetterOrDigit(cTail))
            {
                tail--;
            }
            else
            {
                if (Char.ToLower(cHead) != Char.ToLower(cTail))
                {
                    return false;
                }
                head++;
                tail--;
            }
        }

        return true;
    }
}