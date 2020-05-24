using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5419
{
    public int MaxDotProduct(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;

        int[,] products = new int[m, n];
        for(int i =0; i < m; ++i)
            for(int j =0; j < n; ++j)
            {
                products[i, j] = nums1[i] * nums2[j];
            }

        int[,] dp = new int[m, n];
        
        int max = int.MinValue;
        for(int i =0; i < m; ++i)
            for(int j =0; j < n; ++j)
            {
                dp[i, j] = Math.Max(j>0? dp[i, j -1]: int.MinValue, i>0? dp[i -1, j]: int.MinValue);

                var tmp = products[i, j];
                if (i>0 && j>0 &&  dp[i-1, j-1] > 0)
                    tmp += dp[i-1, j-1];


                if(tmp > dp[i, j])
                {
                    dp[i, j] = tmp;
                }

                if(dp[i, j] > max) max = dp[i, j];
            }

        return max;
    }
}