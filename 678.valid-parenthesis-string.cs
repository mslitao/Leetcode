using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution678
{
    public bool CheckValidString(string s) {
        int left = 0;
        for(int i =0; i < s.Length; ++i)
        {
            var c = s[i];
            if(c == '(' || c== '*') left ++;
            else left --;
            if(left <0) return false;
        }

        if(left ==0) return true;
        
        int right = 0;
        for(int i = s.Length -1; i>=0; --i)
        {
             var c = s[i];
            if(c == ')' || c== '*') right ++;
            else right --;
            if(right <0) return false;
        }

        return true;
    }
}