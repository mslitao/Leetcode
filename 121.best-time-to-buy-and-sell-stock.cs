using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution121
{
    public int MaxProfit2(int[] prices) {
        int maxProfit = 0;
        int minPrice = int.MaxValue;
        for(int i =0; i < prices.Length; ++ i)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }

        return maxProfit;
    }
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; ++i)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }
        return maxProfit;
    }
}