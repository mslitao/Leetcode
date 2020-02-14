using System;
using System.Collections.Generic;
using System.Linq;

public class Solution34
{
    public int BinarySearch(int[] nums, int target, int start, int end, bool fromLeft)
    {
        if (end <= start)
        {
            return start;
        }

        int mid = (end + start) / 2;
        if ((nums[mid] == target && fromLeft) || nums[mid] > target)
        {
            return BinarySearch(nums, target, start, mid, fromLeft);
        }
        else
        {
            return BinarySearch(nums, target, mid+1, end, fromLeft);
        }
    }

    public int[] SearchRange(int[] nums, int target)
    {
        int[] results = new int[2] { -1,-1};

        int leftIdx = BinarySearch(nums, target, 0, nums.Length - 1, true);
        if (leftIdx == nums.Length || nums[leftIdx] != target)
        {
            return results;
        }
        int rightIdx = BinarySearch(nums, target, 0, nums.Length - 1, false);

        results[0] = leftIdx;
        results[1] = rightIdx == nums.Length || nums[rightIdx] != target ? rightIdx - 1 : rightIdx;
        return results;
    }
}