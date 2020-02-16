//DP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution70
{
    public int ClimbStairs(int n) 
    {
        if(n <=1) return n;

        // Put a 0 step
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        for(int i = 2; i <= n; ++i)
        {
            dp[i] = dp[i - 1] + dp[i -2]; 
        }

        return dp[n];
    }
}