using System;
using System.Collections.Generic;
using System.Linq;

public class Solution162
{
    public int FindPeakElement(int[] nums) {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
                return i;
        }
        return nums.Length - 1;
    }
}