using System;
using System.Collections.Generic;
using System.Linq;


public class Solution300
{
    public int LengthOfLIS(int[] nums) 
    {
        if(nums.Length < 1) return 0;
        int[] lengthList = new int[nums.Length];

        var maxLength=1;
        for(int i = 0; i< nums.Length; ++i)
        {
            var current = 1;
            for(int j =0; j < i; ++j)
            {
                if(nums[i]>nums[j] && lengthList[j] + 1 > current)
                {
                    current = lengthList[j] + 1 ;
                }
            }

            if(current> maxLength)
                maxLength = current;
            
            lengthList[i] = current;
        }

        return maxLength;
    }
}