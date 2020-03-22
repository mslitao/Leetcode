using System;
using System.Linq;
using System.Collections.Generic;

public class Solution1392
{
    private void getNext(string s, int[] next) {
        int n = s.Length;
        next[0] = 0;
        for (int q = 1, k = 0; q < n; ++q) {
            while (k > 0 && s[q] != s[k])
                k = next[k-1];
            if (s[q] == s[k]) k++;
            next[q] = k;
        }
    }

    public string LongestPrefix(string s) {
        if(string.IsNullOrEmpty(s) || s.Length <= 1) return string.Empty;

        int[] next = new int[s.Length];

        getNext(s, next);

        return s.Substring(0, next.Last());
    }
}