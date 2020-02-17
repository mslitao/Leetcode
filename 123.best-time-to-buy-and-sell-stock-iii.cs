using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution123
{
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        if(n < 2) return 0;

        int buy1 =int.MinValue;
        int sell1 =0;
        int buy2 =int.MinValue;
        int sell2 =0;
        foreach(var price in prices)
        {
            sell2 = Math.Max(sell2, buy2 + price);
            buy2 = Math.Max(buy2, sell1-price);

            sell1 = Math.Max(sell1, buy1 + price);
            buy1 = Math.Max(buy1, -price);
        }
        return sell2;
    }
}