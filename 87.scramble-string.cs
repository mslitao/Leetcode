using System;
using System.Collections.Generic;
using System.Linq;

public class Solution87 
{
    public bool IsScramble(string s1, string s2) {
        if(s1 == s2) return true;
        if(s1.Length != s2.Length ) return false;

        for (int i = 1; i < s1.Length; ++i) {
            string s11 = s1.Substring(0, i);
            string s12 = s1.Substring(i);
            string s21 = s2.Substring(0, i);
            string s22 = s2.Substring(i);
            if (IsScramble(s11, s21) && IsScramble(s12, s22)) return true;

            s21 = s2.Substring(s2.Length - i);
            s22 = s2.Substring(0, s2.Length - i);
            if (IsScramble(s11, s21) && IsScramble(s12, s22)) return true;
        }

        return false;
    }

    public bool IsScrambleDP(string s1, string s2) {
        if(s1 == s2) return true;
        if(s1.Length != s2.Length ) return false;
        
        int n = s1.Length;
        //List<List<List<bool>>> dp = new List<List<List<bool>>>();
        bool[,,] dp = new bool[n + 1, n + 1, n + 1];
        for(int len = 1; len <= n; ++len)
            for(int i = 0; i <= n - len; ++i)
                for(int j =0; j <= n-len; ++j)
                {
                    if(len == 1)
                    {
                        dp[i, j, 1] = s1[i] == s2[j];
                    }
                    else
                    {
                        for(int k = 1; k <len; ++k)
                        {
                            if(dp[i, j, k] && dp[i +k, j+k, len-k] ||
                               dp[i+k,j,len-k] && dp[i, j+len-k, k])
                            {
                                dp[i,j,len] = true;
                            }
                        }
                    }
                }
        return dp[0, 0, n];
    }
}