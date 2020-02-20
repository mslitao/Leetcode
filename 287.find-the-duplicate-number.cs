using System;
using System.Collections.Generic;
using System.Linq;

public class Solution287
{
    public int FindDuplicate(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            while (nums[i] != i + 1) {
                if (nums[nums[i] - 1] != nums[i]) swap(nums, nums[i] - 1, i);
                else return nums[i];
            }
        }
        return -1;
    }

    public void swap(int[] nums, int i , int j)
    {
        var tmp = nums[i];
        nums[i] =nums[j];
        nums[j]= tmp;
    }
}