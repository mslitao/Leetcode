using System;
using System.Collections.Generic;

public class Solution28
{   
    public int StrStr(string haystack, string needle) 
    {
        if(string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle)) return 0;
        if(string.IsNullOrEmpty(needle) )
        {
            return 0;
        }
        
        if(string.IsNullOrEmpty(haystack)|| haystack.Length < needle.Length)
        {
            return -1;
        }
        
        int m = haystack.Length;
        int n = needle.Length;

        for (int i = 0; i <= m - n; ++i) {
            int j = 0;
            for (j = 0; j < n; ++j) {
                if (haystack[i + j] != needle[j]) break;
            }
            if (j == n) return i;
        }
        return -1;
    }
}