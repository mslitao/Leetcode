using System;
using System.Collections.Generic;
using System.Linq;

public class Solution334
{
    public bool IncreasingTriplet(int[] nums) {
        int min1 = int.MaxValue; 
        int min2 = int.MaxValue;
        int min3 = int.MaxValue;
        for(int i =0; i < nums.Length; ++i)
        {
            if(nums[i] < min1) 
                min1 = nums[i];
            else if (nums[i] > min1 && nums[i] < min2)
                min2 = nums[i];
            else if (nums[i] > min2 && nums[i] < min3)
                min3 = nums[i];
        }
        
        Console.WriteLine(min1);
        Console.WriteLine(min2);
        Console.WriteLine(min3);
        return min1 != int.MaxValue && min2 != int.MaxValue && min3 != int.MaxValue
                && min1 < min2 && min2 < min3;
    }

    public bool IncreasingTripletDP(int[] nums) {
        if(nums == null || nums.Length <3) return false;
        int[] dp = new int[nums.Length];
        Array.Fill(dp, 1);

        for(int i = 1; i < nums.Length; ++i)
        {
            for (int j = 0; j < i; ++j) {
                if (nums[j] < nums[i]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    if (dp[i] >= 3) return true;
                }
            }
        }
        return false;
    }

}