using System;
using System.Linq;
using System.Collections.Generic;

public class Solution459
{
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length;
        for (int i = n / 2; i >= 1; --i) {
            if (n % i == 0) {
                int c = n / i;
                string t = "";
                for (int j = 0; j < c; ++j) {
                    t += s.Substring(0, i); 
                }
                if (t == s) return true;
            }
        }
        return false;
    }

    public bool RepeatedSubstringPatternDP(string s) {
        int i = 1, j = 0, n = s.Length;
        int[] dp = new int[n+1];

        while (i < n) {
            if (s[i] == s[j]) dp[++i] = ++j;
            else if (j == 0) ++i;
            else j = dp[j];
        }
        return dp[n] > 0 && (dp[n] % (n - dp[n]) == 0);
    }
}