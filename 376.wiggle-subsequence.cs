using System;
using System.Collections.Generic;
using System.Linq;

public class Solution376 {
    public int WiggleMaxLength(int[] nums) 
    {
        if(nums == null || nums.Length < 1) return 0;
        int n = nums.Length;
        int[] dpP = new int[n];
        int[] dpN = new int[n];
        
        int result = 0;
        for(int i = 0; i < n; ++i)
        {
            int maxP = 0;
            int maxN = 0;
            for(int j = i-1; j>=0; --j)
            {
                if(nums[i] > nums[j] && dpN[j] > maxP)
                {
                    maxP = dpN[j];
                }

                if(nums[i] < nums[j] && dpP[j] > maxN)
                {
                    maxN = dpP[j];
                }
            }

            dpP[i] =  ++maxP;
            dpN[i] =  ++maxN;
            
            result = Math.Max(result, Math.Max(dpP[i], dpN[i]));
        }
        
        //Console.WriteLine(String.Join("-", dpP));
        //Console.WriteLine(String.Join("-", dpN));

        return result;
    }
}