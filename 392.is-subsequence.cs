using System;
using System.Collections.Generic;

public class Solution392 {
    public bool IsSubsequence(string s, string t) 
    {
        if(t == null && s == null) return true;
        if(t == null) return false;
        if(s == null) return true;

        var lenT = t.Length;
        var lenS = s.Length;
        if(lenT < lenS)
        {
            return false;
        }

        int idxT =0;
        int idxS = 0;
        while(idxS < lenS && idxT < lenT)
        {
            if(s[idxS] == t[idxT])
            {
                idxS++;
            }
            idxT ++;
        }

        return idxS == lenS;
    }
}