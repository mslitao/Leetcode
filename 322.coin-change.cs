using System;
using System.Collections.Generic;
using System.Linq;

public class Solution322 
{
    public int CoinChange(int[] coins, int amount) {
        // create dp array
        // dp[i]: The min coins needed to get a total amount of i. 
        int[] dp = new int[amount +1];
        // initilize the dp arry to invalid numbers by using Array.Fill
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0; // Set the default to 0, 0 coin to have a 0 valeu

        // For each coin, try to update the min coin count. 
        for(int i = 0; i < coins.Length; ++i)
        {
            var coin = coins[i];
            for(int j = 1; j <= amount; ++j)
            {
                if (j-coins[i] >= 0 && dp[j-coin] != Int32.MaxValue)
                    dp[j] = Math.Min(dp[j-coin]+1, dp[j]);
            }
        }

        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}