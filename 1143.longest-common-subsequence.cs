using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1143
{
    public int LongestCommonSubsequence(string text1, string text2) {
        // DP 2d array
        if(string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2)) return 0;
        int len1 = text1.Length;
        int len2 = text2.Length;
        int[,] dp = new int[len1 + 1, len2 + 1] ;
        
        for(int i =0; i <= len1; ++ i)
        {
            dp[i, 0] = 0;
        }
        for(int j =0; j <= len2; ++ j)
        {
            dp[0, j] = 0;
        }

        for(int i =1; i <= len1; ++ i)
        {
            for(int j = 1; j <= len2; ++ j)
            {
                if(text1[i] == text2[j])
                {
                    dp[i, j] = dp[i-1, j-1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i-1, j], dp[i, j-1]);
                }
            }
        }

        return dp[len1, len2];
    }
}