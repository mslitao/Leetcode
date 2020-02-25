using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution198
{
    public int Rob(int[] nums) 
    {
        var len = nums.Length;
        if(len ==0)
            return 0;
        int[] dp1 = new int[len + 1]; // Yes, rob this one.
        int[] dp2 = new int[len + 1]; // No, skip this one.

        dp1[0] = 0;
        dp2[0] = 0;
        for(int i =1; i <= len; i ++)
        {
            // If rob at this house, add the value from this hourse
            // together with the carried value from the DP2 yesterday (skip at last house)
            dp1[i] = nums[i - 1] + dp2[i - 1];

            // If skip this house, the max value at today of dp2
            // either rob or skip at last one.
            dp2[i] = Math.Max(dp2[i-1], dp1[i-1]);
        }
        
        // Take the max at the last house.
        return Math.Max(dp2[len], dp1[len]);
    }
}