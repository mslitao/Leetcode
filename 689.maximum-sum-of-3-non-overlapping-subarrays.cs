using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution689
{
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int n = nums.Length;

        //int start1, start 2, start 3
        int[] sumR = new int[n];
        int start = 0;
        int end = 0;
        int sum = 0;
        while(end < n)
        {
            sum += nums[end++];
            if(end - start > k) sum -= nums[start ++];
            if(end - start == k) sumR[start] = sum;
        }

        int[] dp1 = new int[n];
        dp1[0] = sumR[0];
        for(int i= 1; i <= n - k; ++i)
        {
            dp1[i] = Math.Max(dp1[i -1], sumR[i]);
        }

        int[] dp2 = new int[n];
        for(int i= k; i <= n - k; ++i)
        {
            dp2[i] = Math.Max(dp2[i-1], sumR[i] + dp1[i - k]);
        }

        int[] dp3 = new int[n];
        for(int i= 2*k; i <= n - k; ++i)
        {
            dp3[i] = Math.Max(dp3[i-1], sumR[i] + dp2[i - k]);
        }

        int[] results = new int[3];
        int max3 = int.MinValue;
        for(int i= 2*k; i <= n - k; ++i)
        {
            if(dp3[i] > max3)
            {
                results[2] = i;
                max3 = dp3[i];
            }
        }

        int max2 = dp3[results[2]] - sumR[results[2]];
        for(int i= k; i <= n - k; ++i)
        {
            if(dp2[i] == max2)
            {
                results[1] = i;
                break;
            }
        }

        int max1 = dp2[results[1]] - sumR[results[1]];
        for(int i= 0; i <= n - k; ++i)
        {
            if(dp1[i] == max1)
            {
                results[0] = i;
                break;
            }
        }

        //Console.WriteLine
        return results;
    }
}