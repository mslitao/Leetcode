using System;
using System.Linq;
using System.Collections.Generic;

public class Solution1389
{
    public int[] CreateTargetArray(int[] nums, int[] index) {
        if(nums== null || index == null || nums.Length != index.Length || nums.Length ==0) return nums;

        int size = nums.Length;
        List<int> results = new List<int>();

        for(int i = 0; i < size; ++i)
        {
            results.Insert(index[i], nums[i]);
        }

        return results.ToArray();
    }
}