using System;
using System.Collections.Generic;
using System.Linq;

public class Solution309 {
    public int MaxProfit(int[] prices) 
    {
        int n = prices.Length;
        if(n< 2)
        return 0;
        int[] buys = new int[n];
        int[] sells = new int[n];
        int[] nas = new int[n];
        buys[0] = 0 - prices[0];
        sells[0] = int.MinValue; //
        nas[0] = 0; // at begining, it's 0

        for(int i =1; i <n; ++i)
        {
            var price = prices[i];
            buys[i]  = Math.Max(nas[i-1] - price, buys[i-1]);

            sells[i] = Math.Max(buys[i-1] + price, sells[i-1]);

            nas[i] = Math.Max(nas[i-1], Math.Max( sells[i-1], buys[i-1]));
        }

        return Math.Max(nas[n -1 ], Math.Max( sells[n - 1], buys[n - 1]));
    }
}