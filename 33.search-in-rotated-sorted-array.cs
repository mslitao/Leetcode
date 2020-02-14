using System;
using System.Collections.Generic;
using System.Linq;

public class Solution33
{
    public int Search(int[] nums, int target) 
    {
        // Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        // Solution 1: Sort and find target O(nlog(n)) + O(n)
        // Requirement is log(n)
        return BinarySearch(nums, 0, nums.Length -1, target);
    }
    
    public int BinarySearch(int[] nums, int start, int end, int target)
    {
        if(start > end)
            return -1;

        int middle = start + (end - start)/2;

        if(nums[middle] == target)
            return middle;

        bool hasReverse = nums[start] > nums[end];
        if(nums[middle] < target)
        {
            var res = BinarySearch(nums, middle + 1, end, target);
            if(hasReverse && res == -1)
            {
                return BinarySearch(nums, start, middle - 1, target);
            }
            else
                return res;
        }
        else
        {
            var res = BinarySearch(nums, start, middle - 1, target);
            if(hasReverse && res == -1)
            {
                return BinarySearch(nums, middle + 1, end, target);
            }
            else
                return res;
        }
    }
}