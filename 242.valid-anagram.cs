using System;
using System.Collections.Generic;
using System.Linq;

public class Solution242
{
    public bool IsAnagram(string s, string t) 
    {
        if(String.IsNullOrEmpty(s) && String.IsNullOrEmpty(t) ) return true;
        if(String.IsNullOrEmpty(s) || String.IsNullOrEmpty(t)) return false;
        if(s.Length != t.Length) return false;
        int[] sMap = new int[26];
        int[] tMap = new int[26];
        
        for(int i = 0; i < s.Length; ++i)
        {
            sMap[s[i] - 'a']  =  sMap[s[i] - 'a']  + 1;
            tMap[t[i] - 'a']  =  tMap[t[i] - 'a']  + 1;
        }

        for(int i =0; i < 26; ++i)
        {
            if(sMap[i] != tMap[i])
                return false;
        }
        return true;
    }
}