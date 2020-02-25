using System;
using System.Collections.Generic;
using System.Linq;

public class Solution343
{
    // Dp Logic
    public int IntegerBreak(int n) 
    {
        int[] dp = new int[n + 1];

        dp[0] = 1;
        dp[1] = 1;
        for(int i = 2; i <= n; ++i)
        {
            int max = int.MinValue;
            for(int j = i-1; j>=1; --j)
            {
                max = Math.Max(max, (i - j)*dp[j]);
                max = Math.Max(max, (i - j)*j);
            }
            dp[i] = max;
        }

        return dp[n];
    }
}