using System;
using System.Collections.Generic;
using System.Linq;

public class Solution674
{
    public int FindLengthOfLCIS(int[] nums) 
    {
        if (nums.Length < 1)
        {
            return 0;
        }

        int maxLength = 0;
        int length = 0;
        int lastNum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i == 0 || nums[i] <= lastNum)
            {
                if (length > maxLength)
                    maxLength = length;
                length = 1;
                lastNum = nums[i];
            }
            else
            {
                lastNum = nums[i];
                length++;
            }
        }
        
        if (length > maxLength)
            maxLength = length;

        return maxLength;
    }
}