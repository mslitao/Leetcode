using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution97
{
    public bool IsInterleave(string s1, string s2, string s3) {
        if(string.IsNullOrWhiteSpace(s1)) return s2 == s3;
        if(string.IsNullOrWhiteSpace(s2)) return s1 == s3;
        if(string.IsNullOrWhiteSpace(s3)) return false;

        int m = s1.Length;
        int n = s2.Length;
        if(s3.Length != m + n) return false;

        bool[,] dp = new bool[m+1, n+1];
        dp[0,0] = true;
        for(int i =1; i <= n; ++i)
        {
            dp[0,i] = dp[0, i-1] && s2[i-1] == s3[i-1];
        }
        for(int i =1; i <= m; ++i)
        {
            dp[i,0] = dp[i-1, 0] && s1[i-1] == s3[i-1];
        }

        for(int i = 1; i <= m; ++i)
            for(int j = 1; j <= n; ++j)
            {
                dp[i,j] = dp[i, j-1] && s3[i + j -1] == s2[j-1] ||
                          dp[i-1, j] && s3[i + j -1] == s1[i-1];
            }
        return dp[m,n];
    }
}