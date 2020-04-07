using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution81
{
    public bool Search(int[] nums, int target) {
        if(nums == null || nums.Length == 0 ) return false;

        return BinarySearch(nums, target, 0, nums.Length -1)
    }

    public bool BinarySearch(int[] nums, int target, int left, int right)
    {
        if(left > right) return false;
        if(left == right) return nums[left] == target;

        int middle = left + (right  - left) / 2;
        if(nums[middle] == target)
        {
            return true;
        }
        else if(nums[middle] < target)
        {
            return BinarySearch(nums, target, middle + 1, right) ||
                    (nums[left] >= nums[right]  && BinarySearch(nums, target, left, middle - 1));
        }
        else
        {
            return BinarySearch(nums, target, left, middle - 1) ||
                   (nums[left] >= nums[right]  && BinarySearch(nums, target, middle + 1, right));
        }
    }
}