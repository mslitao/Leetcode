using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution122
{
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        if(n < 2) return 0;

        int[] buys = new int[n];
        int[] sells = new int[n];
        buys[0] = 0 - prices[0];
        sells[0] = 0;

        for(int i =1; i< n; ++i)
        {
            int price = prices[i];
            //no actions today, or buys on today (need to carry the profit from sells before.)
            buys[i] = Math.Max(buys[i-1], sells[i-1] - price);

            // no actions today, or sell on today (carray the profit of buys from before.)
            sells[i] = Math.Max(sells[i-1], buys[i-1] + price);
        }

        return Math.Max(buys[n-1], sells[n-1]);
    }

    public int MaxProfit2(int[] prices) {
        int n = prices.Length;
        if(n < 2) return 0;

        int profit =0;
        int minPrice = int.MaxValue;
        

        for(int i =0; i< n; ++i)
        {
            int price = prices[i];
            if(price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                profit += (price - minPrice);
                minPrice = price;
            }
        }

        return profit;
    }
}