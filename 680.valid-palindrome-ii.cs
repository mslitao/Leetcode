using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution680
{
    public bool ValidPalindrome(string s) {
        if(string.IsNullOrEmpty(s)) return true;

        return ValidPalindrome(s, 0, s.Length -1, true);
    }

    public bool ValidPalindrome(string s, int i, int j, bool noEdit) 
    {
        if(i > j) return true;
        if(s[i] == s[j])
        {
            return ValidPalindrome(s, i+1, j-1, noEdit);
        }
        else if(noEdit)
        {
            return ValidPalindrome(s, i, j-1, false) || ValidPalindrome(s, i+1, j, false);
            
        }
        else
        {
            return false;
        }
    }
}