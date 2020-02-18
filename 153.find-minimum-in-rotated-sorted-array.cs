using System;
using System.Collections.Generic;
using System.Linq;

public class Solution153
{
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] > nums[high]) { low = mid+1; }
            else high = mid;
        }

        return nums[low];
    }
}