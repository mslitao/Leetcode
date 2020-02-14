using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution44
{
    public bool IsMatch(string s, string p) 
    {
        int m = s.Length;
        int n = p.Length;
        int i =0;
        int j =0;
        int iStar = -1;
        int jStar = -1;
        while(i < m)
        {
            // match current character by 1. character or ?
            if(j<n && (s[i] == p[j] || p[j] == '?'))
            {
                ++i; ++j;
            }
            // ignore the * and continue to match next char in p
            else if (j < n && p[j] == '*')
            {
                iStar = i;
                jStar = j;
                j++;
            }
            // if failed to match, go back to previous star
            else if(iStar >=0)
            {
                i = ++iStar;
                j = jStar +1;
            }
            // if no star in the previous, failed.
            else 
            {
                return false;
            }
        }
        
        while(j < n && p[j] == '*')
        {
            ++j;
        }

        return j == n;
    }
}