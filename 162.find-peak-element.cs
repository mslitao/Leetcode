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

    public int FindPeakElement_BinarySearch(int[] nums) {
        return BPFindPeakElement(nums, 0, nums.Length -1 );
    }

    public int BPFindPeakElement(int[] nums, int low, int high)
    {
        if(low == high) return low;
        if(low + 1 == high) 
            return nums[low] > nums[high] ? low: high;

        int middle = low + (high - low) / 2;
        if(nums[middle] > nums[middle - 1] && nums[middle] > nums[middle -1])
        {
            return middle;
        }
        else if (nums[middle -1] > nums[middle])
        {
            return BPFindPeakElement(nums, low, middle -1);
        }
        else
        {
            return BPFindPeakElement(nums, middle + 1, high);
        }
    }

    public int FindPeakElement_BinarySearch2(int[] nums) 
    {
        int left = 0; 
        int right = nums.Length -1;
        while(left < right)
        {
            int middle = left + (right - left) / 2;
            if(nums[middle] < nums[middle + 1]) left = middle + 1;
            else
                right = middle; 
        }
        return BPFindPeakElement(nums, 0, nums.Length -1 );
    }
}