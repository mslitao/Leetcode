using System;
using System.Collections.Generic;

public class Solution1347 {
    public int MinSteps(string s, string t) {
        if(string.IsNullOrEmpty(s) || s.Length == 0) return 0;
        int[] charsInS = new int[26];
        int[] charsInT = new int[26];
        
        for(int i =0; i < s.Length; ++i)
        {
            charsInS[s[i] - 'a'] ++;
            charsInT[t[i] - 'a'] ++;
        }
        
        int cnt = 0;
        for(int i =0; i < 26; ++i)
        {
            if(charsInS[i] > 0 && charsInS[i] > charsInT[i])
            {
                cnt += Math.Abs(charsInS[i] - charsInT[i]);
            }
        }
        
        return cnt;
    }
}