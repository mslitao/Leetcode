using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution746
{
    public int MinCostClimbingStairs(int[] cost) {
        if(cost == null || cost.Length ==0) return 0;
        int n = cost.Length;

        int[] dp = new int[n + 1];
        dp[0] = cost[0]; // Sta
        dp[1] = cost[1];

        if(n <= 2)
            return cost[0];

        for(int i = 2; i < n; ++i)
        {
            dp[i] = Math.Min(dp[i - 1] + cost[i], dp[i -2] + cost[i]);
        }
        
        return Math.Min(dp[n-1], dp[n -2]);
    }
}