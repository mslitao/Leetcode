using System;
using System.Collections.Generic;
using System.Linq;

public class Solution32 {
    public int LongestValidParentheses(string s) {
        if(string.IsNullOrEmpty(s) || s.Length <2) return 0;
        List<int> dpArray = new List<int>();
        for(int i =0;i < s.Length; ++i)
        {
            dpArray.Add(0);
        }

        for(int i =0; i < s.Length; ++i)
        {
            if(s[i] =='(')
                continue;
            
            if(i-1>=0&& s[i-1]=='(')
            {
                dpArray[i] = 2 + (i-2>=0? dpArray[i-2]:0);
            }
            else if(i -1 >=0 && s[i-1]== ')')
            {
                if(i - dpArray[i-1]-1 >=0 && s[i-dpArray[i-1]-1] =='(')
                {
                    dpArray[i] = 2 + dpArray[i-1] + (i - dpArray[i-1]-2 >=0?dpArray[i - dpArray[i-1]-2]:0);
                }
            }
        }

        return dpArray.Max();
    }
}