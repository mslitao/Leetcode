using System;
using System.Collections.Generic;
using System.Linq;

public class Solution324
{
    public void WiggleSort(int[] nums) {
        if(nums.Length<=1) return ;
        Array.Sort(nums);
        var copy = nums.Clone() as int[];
        var mid = nums.Length%2 ==0? (nums.Length/2-1): (nums.Length/2); // right base mid index
        for(var i=0;i<nums.Length;i++){
            nums[i] = i%2==0? copy[mid-i/2]: copy[nums.Length-1 - i/2]; // refer to https://discuss.leetcode.com/topic/41464/step-by-step-explanation-of-index-mapping-in-java
        }
    }
}